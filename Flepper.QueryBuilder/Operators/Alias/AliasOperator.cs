﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Flepper.QueryBuilder.Base;
using Flepper.QueryBuilder.Operators.SqlFunctions;

namespace Flepper.QueryBuilder
{
    internal class AliasOperator : BaseQueryBuilder, IAliasOperator
    {
        public AliasOperator(StringBuilder command, IDictionary<string, object> parameters, SqlColumn[] columns) : base(command, parameters, columns)
        {
        }

        public IAliasOperator As(string alias)
        {
            var withoutFunctions = Columns
                .Where(c => !c.GetType().IsSubclassOf(typeof(FunctionOperator)))
                .Select(c => c.TableAlias != null ? c : new SqlColumn($"[{alias}].{c}")).ToArray();
            
            var withFunctions = Columns
                .Where(c => c.GetType().IsSubclassOf(typeof(FunctionOperator)))
                .Select(c => c.TableAlias != null 
                    ? c 
                    : (SqlColumn)Activator.CreateInstance(c.GetType(),$"{extractColumnFromFunction(c)}",c.Alias,alias)).ToArray();

            Columns = withFunctions.Concat(withoutFunctions).ToArray();
            var command = Command.ToString();

            Command.Clear();
            Command.Append($"SELECT {string.Join(",", Columns.Select(c => c.ToString()))} FROM {command.Split(new[] { "FROM " }, StringSplitOptions.RemoveEmptyEntries)[1].Trim()} ");

            Command.AppendFormat("{0} ", alias);

            return this;
        }

        private string extractColumnFromFunction(SqlColumn c)
            => $"{c.Column.Split('[')[1].ToString().Split(']')[0]}";
        
    }
}