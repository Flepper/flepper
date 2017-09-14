using System.Text;
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    internal class TopCommand : BaseQueryBuilder, ITopCommand
    {
        public TopCommand(StringBuilder command, int size = 1) : base (command)
            => Command.Replace("SELECT ", $"SELECT TOP {size} ");
    }
}