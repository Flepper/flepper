#addin nuget:?package=Cake.Codecov
#tool nuget:?package=Codecov
#tool "nuget:?package=OpenCover"
#tool "nuget:?package=xunit.runner.console&version=2.2.0"
#tool "nuget:?package=ReportGenerator"

var target = Argument("target", "Default");
var testProject = "./Flepper.Tests.Unit/Flepper.Tests.Unit.csproj";
var integrationTestProject = "./Flepper.Tests.Integration/Flepper.Tests.Integration.csproj";
var testSettings = new DotNetCoreTestSettings { Configuration = "Release", NoBuild = true };

Task("Default").Does(() =>
{
    Information("Hello World!");
});

Task("CiBuild").IsDependentOn("Coverage").IsDependentOn("NugetPack").Does(() =>
{
});

Task("CoverageHtmlReport").IsDependentOn("Build").Does(() =>
{
    var settings = new OpenCoverSettings()
    {
        MergeOutput = true,
        SkipAutoProps = true,
        OldStyle = true,
        Register = "user",
        ArgumentCustomization = builder => builder.Append("-hideskipped:File")
    };
    settings.WithFilter("+[Flepper.QueryBuilder*]*").WithFilter("-[Flepper.Tests.Unit*]*");

    OpenCover(t => t.DotNetCoreTest(testProject, testSettings), new FilePath("./coverage.xml"), settings);

    ReportGenerator("./coverage.xml", "./reportoutput");
});

Task("Coverage").IsDependentOn("Build").Does(() =>
{
    var settings = new OpenCoverSettings()
    {
        MergeOutput = true,
        SkipAutoProps = true,
        OldStyle = true,
        Register = "user",
        ArgumentCustomization = builder => builder.Append("-hideskipped:File")
    };
    settings.WithFilter("+[Flepper.QueryBuilder*]*").WithFilter("-[Flepper.Tests.Unit*]*");

    OpenCover(t => t.DotNetCoreTest(testProject, testSettings), new FilePath("./coverage.xml"), settings);

    Codecov("./coverage.xml");
});

Task("NugetPack").IsDependentOn("Build").Does(() =>
{
    var settings = new DotNetCorePackSettings
    {
        Configuration = "Release",
        OutputDirectory = "./artifacts/",
        NoBuild = true
    };

    DotNetCorePack("./Flepper.QueryBuilder/Flepper.QueryBuilder.csproj", settings);
});

Task("Tests").IsDependentOn("Integration-Tests").IsDependentOn("Build").Does(() =>
{
    DotNetCoreTest(testProject, testSettings);
});

Task("Integration-Tests").IsDependentOn("Build").Does(() =>
{
    DotNetCoreTest(integrationTestProject, testSettings);
});

Task("Build").Does(() =>
{
    DotNetCoreBuild("./Flepper.sln",new DotNetCoreBuildSettings { Configuration = "Release" });
});

RunTarget(target);
