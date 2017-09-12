using System;
using System.Text;

namespace Flepper.QueryBuilder.Base
{
    internal abstract class BaseQueryBuilder : IQueryCommand
    {
        private readonly StringBuilder Command;

        protected BaseQueryBuilder()
            => Command = new StringBuilder();

        protected BaseQueryBuilder(StringBuilder command)
            => Command = command;

        public string Build()
            => Command.ToString();

        public TEnd To<TEnd>()
            where TEnd : IQueryCommand
            => (TEnd)Activator.CreateInstance(typeof(TEnd), Command);

        public TEnd To<TEnd>(Func<StringBuilder, TEnd> creator)
            => creator(Command);
    }
}
