using System;
namespace Flepper.QueryBuilder
{
    /// <summary>
    /// 
    /// </summary>
    public interface IInsertIntoIQueryCommand : IQueryCommand
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="columns"></param>
        /// <param name="query"></param>
        /// <returns></returns>
        IInsertIntoIQueryCommand Columns(string[] columns, Func<IQueryCommand, IQueryCommand> query);        
    }
}
