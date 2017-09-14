using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Utils.Extensions;

namespace Flepper.QueryBuilder
{
    internal class SelectTopCommand : BaseQueryBuilder, ISelectCommand
    {
        public SelectTopCommand() => Command.Append("SELECT TOP 1 * ");

        public SelectTopCommand(params string[] columns) => Command.AppendFormat("SELECT TOP 1 {0}", columns.JoinColumns());

        public SelectTopCommand(int numberLines) => Command.AppendFormat("SELECT TOP {0} * ", numberLines);

        public SelectTopCommand(int numberLines, params string[] columns) => Command.AppendFormat("SELECT TOP {0} {1}", numberLines, columns.JoinColumns());
    }
}