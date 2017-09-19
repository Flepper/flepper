namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : IOnOperator
    {
        public IOnOperator On(string tableAlias, string column)
        {
            Command.AppendFormat("ON {0}.[{1}] ", tableAlias, column);
            return this;
        }
    }
}
