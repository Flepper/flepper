namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : ITopCommand
    {
        public ITopCommand TopCommand(int size = 1)
        {
            Command.Replace("SELECT ", $"SELECT TOP {size} ");
            return this;
        }
    }
}