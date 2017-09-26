﻿using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class TopCommand : BaseQueryBuilder, ITopCommand
    {
        public TopCommand(StringBuilder command, IDictionary<string, object> parameters, SqlColumn[] columns, int size = 1) : base(command, parameters, columns)
            => Command.Replace("SELECT ", $"SELECT TOP {size} ");
    }
}