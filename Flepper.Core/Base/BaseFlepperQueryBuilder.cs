
using System.Text;

namespace Flepper.Core.Base
{
    public abstract class BaseFlepperQueryBuilder
    {
        protected static StringBuilder Command = new StringBuilder();

        public string SqlQuery => Command.ToString();

        public void ExecuteQuery()
        {
            //TODO: Execute Dapper Query Method;
            Command = new StringBuilder();
        }
    }
}
