using Flepper.QueryBuilder.Utils;

namespace Flepper.QueryBuilder
{
    public static class FlepperQueryBuilder
    {
        public static ISelectCommand Select()
            => new SelectCommand();

        public static ISelectCommand Select(params string[] columns)
            => new SelectCommand(columns);

        public static ISelectCommand Select<T>() where T : class
            => new SelectCommand(Cache.GetDtoProperties<T>());

        public static IInsertCommand Insert()
            => new InsertCommand();

        public static IDeleteCommand Delete()
            => new DeleteCommand();

        public static IUpdateCommand Update(string table)
            => new UpdateCommand(table);

        public static IUpdateCommand Update(string schema, string table)
            => new UpdateCommand(schema, table);
    }
}
