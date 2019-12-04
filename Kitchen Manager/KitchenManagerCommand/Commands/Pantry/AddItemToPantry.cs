using Dapper;
using KitchenManagerCommand.Models;
using System;
using System.Data.SqlClient;

namespace KitchenManagerCommand.Commands.Pantry
{
    public class AddItemToPantry
    {
        public void AddItem(Contents contents)
        {
            contents.Id = Guid.NewGuid();
            contents.CreatedDate = DateTime.UtcNow;
            contents.PurchaseDate = DateTime.UtcNow;
            contents.ExpirationDate = DateTime.UtcNow.AddDays(14);
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"INSERT INTO Pantry (ID, Name, Ounces, PurchaseDate, CreatedDate, ExpirationDate) VALUES ( @Id, @Name, @Ounces, @PurchaseDate, @CreatedDate, @ExpirationDate)";
                context.Execute(sql, new { @Id = contents.Id, @Name = contents.Name, @Ounces = contents.Ounces, @PurchaseDate = contents.PurchaseDate, @CreatedDate = contents.CreatedDate, @ExpirationDate = contents.ExpirationDate });
            }
        }
    }
}
