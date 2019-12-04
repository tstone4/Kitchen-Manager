using Dapper;
using KitchenManagerQuery.Models;
using System;
using System.Data.SqlClient;
using System.Linq;

namespace KitchenManagerQuery.Queries.Pantry
{
    public class GetItemFromPantry
    {
        public Contents GetItem(Guid Id)
        {
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"SELECT * FROM Pantry WHERE Id = @id";
                var x = context.Query<Contents>(sql, new { @id = Id }).FirstOrDefault();
                return x;
            }
        }
    }
}
