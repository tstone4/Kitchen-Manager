using Dapper;
using KitchenManagerQuery.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace KitchenManagerQuery.Queries.Freezer
{
    public class GetItemFromFreezer
    {
        public Contents GetItem(Guid Id)
        {
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"SELECT * FROM Freezer WHERE Id = @id";
                var x = context.Query<Contents>(sql, new { @id = Id }).FirstOrDefault();
                return x;
            }
        }
    }
}
