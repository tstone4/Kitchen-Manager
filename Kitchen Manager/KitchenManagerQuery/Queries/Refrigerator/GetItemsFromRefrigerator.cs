using Dapper;
using KitchenManagerQuery.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace KitchenManagerQuery.Queries.Refrigerator
{
    public class GetItemsFromRefrigerator
    {
        public List<Contents> GetItems()
        {
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"SELECT top 100 * FROM Refrigerator";
                var x = context.Query<Contents>(sql).ToList();
                return x;
            }
        }
    }
}
