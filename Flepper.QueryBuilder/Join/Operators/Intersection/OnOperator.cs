﻿using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class OnOperator : BaseQueryBuilder, IOnOperator
    {
        public OnOperator(StringBuilder command, IDictionary<string, object> parameters, SqlColumn[] columns) : base(command, parameters, columns)
        {
        }

        public IOnOperator On(string tableAlias, string column)
        {
            Command.AppendFormat("ON {0}.[{1}] ", tableAlias, column);
            return this;
        }
    }
}
