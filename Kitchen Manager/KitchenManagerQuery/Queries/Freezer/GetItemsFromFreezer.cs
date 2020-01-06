using Dapper;
using KitchenManagerQuery.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace KitchenManagerQuery.Queries.Freezer
{
    public class GetItemsFromFreezer
    {
        public List<Contents> GetItems()
        {
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"SELECT top 100 * FROM Freezer";
                var x = context.Query<Contents>(sql).ToList();
                return x;
            }
        }
    }
}
