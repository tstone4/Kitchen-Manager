using Dapper;
using System;
using System.Data.SqlClient;

namespace KitchenManagerCommand.Commands.Freezer
{
    public class DeleteItemFromFreezer
    {
        public void DeleteItem(Guid Id)
        {
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"DELETE FROM Freezer WHERE Id=@id";
                context.Execute(sql, new { @id = Id });
            }
        }
    }
}
