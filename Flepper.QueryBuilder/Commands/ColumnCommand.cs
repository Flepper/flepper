using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Operators.SqlFunctions.Interfaces;
using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder
{

    internal class ColumnCommand : BaseQueryBuilder, IColumnCommand
    {
        public ColumnCommand(StringBuilder command, IDictionary<string, object> parameters, ISqlFunction sqlFunction) : base(command, parameters)
        => Command.AppendFormat("{0} ", sqlFunction.GetType());
    }
}
