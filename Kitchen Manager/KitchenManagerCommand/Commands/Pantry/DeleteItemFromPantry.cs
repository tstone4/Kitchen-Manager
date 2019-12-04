using Dapper;
using System;
using System.Data.SqlClient;

namespace KitchenManagerCommand.Commands.Pantry
{
    public class DeleteItemFromPantry
    {
        public void DeleteItem(Guid Id)
        {
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"DELETE FROM Pantry WHERE Id=@id";
                context.Execute(sql, new { @id = Id });
            }
        }
    }
}
