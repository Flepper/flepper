using System.Collections.Generic;
using System.Text;

namespace Flepper.QueryBuilder.Utils.Extensions
{
    internal static class StringBuilderExtensions
    {
        public static StringBuilder Replace(this StringBuilder str, IDictionary<string, string> values)
        {
            if (values?.Count == 0) return str;
            foreach (var dic in values)
                str = str.Replace(dic.Key, dic.Value);
            return str;
        }
    }
}
