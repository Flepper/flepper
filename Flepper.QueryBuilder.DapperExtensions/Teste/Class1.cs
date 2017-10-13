using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;

namespace Flepper.QueryBuilder.DapperExtensions.Teste
{
    class DapperTests
    {
        public void Xpto()
        {
            IDbConnection dbConnection = default(IDbConnection);

            List<Temp> temps = dbConnection.Query<Temp>("", null).ToList();
            IQueryCommand comparisonOperators = dbConnection.Select().From("SeiLa").Where("x").EqualTo(1);
            //List<Temp> enumerable = comparisonOperators.Query<Temp>().ToList();
        }
    }

    class Temp
    {
        public string Nome { get; set; }
    }
}
