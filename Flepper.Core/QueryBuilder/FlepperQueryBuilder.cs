
namespace Flepper.Core.QueryBuilder
{
    public static class FlepperQueryBuilder
    {
        public static ISelectCommand Select()
        {
            return new SelectCommand().Select();
        }

        public static ISelectCommand Select(params string[] columns)
        {
            return new SelectCommand().Select(columns);
        }

        public static IDeleteCommand Delete()
        {
            return new DeleteCommand().Delete();
        }
    }
}
