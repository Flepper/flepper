
using System.Text;

namespace Flepper.QueryBuilder.Base
{
    internal abstract class BaseQueryBuilder
    {
        protected static StringBuilder Command = new StringBuilder();

        public static string Query => Command.ToString();

        protected static void BeforeExecute() => Command = new StringBuilder();
    }
}
