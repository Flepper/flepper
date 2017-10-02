using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal partial class QueryBuilder : ISelectCommand
    {
        public SelectCommand()
        {
            Columns = new[] { (SqlColumn)"*" };
            Command.Append("SELECT * ");
        }

        public SelectCommand(params SqlColumn[] columns)
        {
            if (columns.Any(c => c == null))
                throw new ArgumentNullException(nameof(columns), "All columns names should not be null");

            Columns = columns;

            Command.AppendFormat("SELECT {0}", columns.Select(c => c.ToString()).JoinColumns());
        }
    }
}
