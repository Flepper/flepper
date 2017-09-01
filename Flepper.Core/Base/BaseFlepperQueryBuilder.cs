
using System.Text;

namespace Flepper.Core.Base
{
    public abstract class BaseFlepperQueryBuilder
    {
        protected static StringBuilder Command = new StringBuilder();

        public static string Query => Command.ToString();

        protected static void BeforeExecute() => Command = new StringBuilder();
    }
}
