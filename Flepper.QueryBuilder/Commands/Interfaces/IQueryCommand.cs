using System;
using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder
{
    public interface IQueryCommand
    {
        string Build();
        QueryResult BuildWithParameters();

        TEnd To<TEnd>() where TEnd : IQueryCommand;
        TEnd To<TEnd>(Func<StringBuilder, IDictionary<string, object>, TEnd> creator);
    }
}