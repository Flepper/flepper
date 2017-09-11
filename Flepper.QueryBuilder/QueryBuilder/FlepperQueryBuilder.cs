
using Flepper.QueryBuilder.Base;

namespace Flepper.QueryBuilder
{
    public static class FlepperQueryBuilder
    {
        public static string Query => BaseQueryBuilder.Query;

        public static ISelectCommand Select()
        {
            return new SelectCommand().Select();
        }

        public static ISelectCommand Select(params string[] columns)
        {
            return new SelectCommand().Select(columns);
        }

        public static IInsertCommand Insert(string table)
        {
            return new InsertCommand().Insert(table);
        }

        public static IInsertCommand Insert(string table, params string[] columns)
        {
            return new InsertCommand().Insert(table, columns);
        }

        public static IDeleteCommand Delete()
        {
            return new DeleteCommand().Delete();
        }

        public static IUpdateCommand Update(string table)
        {
            return new UpdateCommand().Update(table);
        }

        public static IUpdateCommand Update(string schema, string table)
        {
            return new UpdateCommand().Update(schema, table);
        }
    }
}
