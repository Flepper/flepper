using System;

namespace Flepper.QueryBuilder
{
    public interface ISetOperator : IQueryCommand
    {
        ISetOperator Set<T>(string column, T value);
    }
}