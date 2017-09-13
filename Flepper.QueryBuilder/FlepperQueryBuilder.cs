using System.Linq;

namespace Flepper.QueryBuilder
{
    public static class FlepperQueryBuilder
    {
        public static ISelectCommand Select()
            => new SelectCommand();

        public static ISelectCommand Select(params string[] columns)
            => new SelectCommand(columns);

        public static ISelectCommand Select<T>() where T : class
        {
            var columns = typeof(T).GetProperties()?.Select(x => x.Name).ToArray() ?? new string[] { };
            return new SelectCommand(columns);
        }

        public static IInsertCommand Insert(string table)
            => new InsertCommand(table);

        public static IInsertCommand Insert(string table, params string[] columns)
            => new InsertCommand(table, columns);

        public static IDeleteCommand Delete()
            => new DeleteCommand();

        public static IUpdateCommand Update(string table)
            => new UpdateCommand(table);

        public static IUpdateCommand Update(string schema, string table)
            => new UpdateCommand(schema, table);
    }
}
