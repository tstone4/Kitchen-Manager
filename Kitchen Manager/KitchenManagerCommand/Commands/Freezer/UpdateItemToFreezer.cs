using Dapper;
using KitchenManagerCommand.Models;
using System;
using System.Data.SqlClient;

namespace KitchenManagerCommand.Commands.Freezer
{
    public class UpdateItemToFreezer
    {
        public void UpdateItem(Contents contents)
        {
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                if (contents.ExpirationDate == null)
                    contents.ExpirationDate = DateTime.UtcNow.AddDays(14);

                var sql = @"UPDATE Freezer SET Name = @name, Ounces = @ounces, ExpirationDate = @expirationDate WHERE Id = @id";
                var x = context.Execute(sql, new { @name = contents.Name, @ounces = contents.Ounces, @expirationDate = contents.ExpirationDate, @id = contents.Id });
            }
        }
    }
}
