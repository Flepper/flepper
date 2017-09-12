using System;
using System.Text;

namespace Flepper.QueryBuilder
{
    public interface IQueryCommand
    {
        string Build();

        TEnd To<TEnd>() where TEnd : IQueryCommand;

        TEnd To<TEnd>(Func<StringBuilder, TEnd> creator);
    }
}