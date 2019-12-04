using Dapper;
using KitchenManagerCommand.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace KitchenManagerCommand.Commands.Refrigerator
{
    public class AddItemToRefrigerator
    {
        public void AddItem(Contents contents)
        {
            contents.Id = Guid.NewGuid();
            contents.CreatedDate = DateTime.UtcNow;
            contents.PurchaseDate = DateTime.UtcNow;
            contents.ExpirationDate = DateTime.UtcNow.AddDays(14);
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"INSERT INTO Refrigerator (ID, Name, Ounces, PurchaseDate, CreatedDate, ExpirationDate) VALUES ( @Id, @Name, @Ounces, @PurchaseDate, @CreatedDate, @ExpirationDate)";
                context.Execute(sql, new { @Id = contents.Id, @Name = contents.Name, @Ounces = contents.Ounces, @PurchaseDate = contents.PurchaseDate, @CreatedDate = contents.CreatedDate, @ExpirationDate = contents.ExpirationDate });
            }
        }
    }
}
