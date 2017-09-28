using System.Collections.Generic;
using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder.Base
{
    internal partial class BaseQueryBuilder : ITopCommand
    {
        public ITopCommand TopCommand(int size = 1)
        {
            Command.Replace("SELECT ", $"SELECT TOP {size} ");
            return this;
        }
    }
}