namespace Flepper.QueryBuilder
{
    /// <summary>
    /// Insert Into Command Interface
    /// </summary>
    public interface IInsertIntoCommand : IQueryCommand
    {
        /// <summary>
        /// Columns contract
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        IInsertIntoCommand Columns(params SqlColumn[] columns);

		/// <summary>
		/// Columns contract
		/// </summary>
		/// <param name="columns"></param>
		/// <returns></returns>
		IInsertIntoCommand Columns(string[] columns);
	}
}