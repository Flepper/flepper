
using System.Text;

namespace Flepper.Core.Base
{
    public abstract class BaseFlepperQueryBuilder
    {
        protected static StringBuilder Command = new StringBuilder();

        public string GetQuery()
        {
            var result = Command.ToString();
            Command = new StringBuilder();

            return result;
        }


    }
}
