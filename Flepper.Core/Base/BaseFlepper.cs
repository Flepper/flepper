using System.Text;

namespace Flepper.Core.Base
{
    public abstract class BaseFlepper
    {
        protected static StringBuilder Command = new StringBuilder();

        public string SqlQuery => Command.ToString();
    }
}
