using Dapper;
using KitchenManagerQuery.Models;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace KitchenManagerQuery.Queries.Refrigerator
{
    public class GetItemFromRefrigerator
    {
        public Contents GetItem(Guid Id)
        {
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"SELECT * FROM Refrigerator WHERE Id = @id";
                var x = context.Query<Contents>(sql, new { @id = Id }).FirstOrDefault();
                return x;
            }
        }
    }
}
