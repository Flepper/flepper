
#addin Cake.Coveralls
#addin nuget:?package=Cake.Codecov
#tool coveralls.net
#tool nuget:?package=Codecov
#tool "nuget:?package=OpenCover"
#tool "nuget:?package=xunit.runner.console&version=2.2.0"

var target = Argument("target", "Default");
var testProject = "../Flepper.Tests.Unit/Flepper.Tests.Unit.csproj";
var testSettings = new DotNetCoreTestSettings { Configuration = "Release", NoBuild = true };

Task("Default").Does(() =>
{
    Information("Hello World!");
});

Task("CiBuild").IsDependentOn("Coverage").IsDependentOn("NugetPack").Does(() =>
{
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
    CoverallsNet("./coverage.xml", CoverallsNetReportType.OpenCover);
});

Task("NugetPack").IsDependentOn("Build").Does(() =>
{
    var settings = new DotNetCorePackSettings
    {
        Configuration = "Release",
        OutputDirectory = "../artifacts/",
        NoBuild = true
    };

    DotNetCorePack("../Flepper.QueryBuilder/Flepper.QueryBuilder.csproj", settings);
});

Task("Tests").IsDependentOn("Build").Does(() =>
{
    DotNetCoreTest(testProject, testSettings);
});

Task("Build").Does(() =>
{
    DotNetCoreBuild("../Flepper.sln",new DotNetCoreBuildSettings { Configuration = "Release" });
});

RunTarget(target);