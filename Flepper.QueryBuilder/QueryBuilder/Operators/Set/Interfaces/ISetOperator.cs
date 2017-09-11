using System;

namespace Flepper.QueryBuilder
{
    public interface ISetOperator
    {
        ISetOperator Set(string column, string value);
        ISetOperator Set(string column, int value);
        ISetOperator Set(string column, DateTime value);
    }
}