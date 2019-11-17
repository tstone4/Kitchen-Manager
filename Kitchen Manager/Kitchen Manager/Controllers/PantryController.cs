using Dapper;
using Kitchen_Manager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen_Manager.Controllers
{
    public class PantryController : ControllerBase
    {
        [HttpGet]
        [Route("pantry")]
        public List<Contents> Get()
        {
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"SELECT top 10 * FROM Pantry";
                var x = context.Query<Contents>(sql).ToList();
                return x;
            }
        }
        [HttpPost]
        [Route("pantry")]
        public ActionResult AddPantryItem([FromBody]Contents contents)
        {
            contents.Id = Guid.NewGuid();
            contents.CreatedDate = DateTime.UtcNow;
            contents.PurchaseDate = DateTime.UtcNow;
            using (var context = new SqlConnection("Server=localhost;Database=KitchenManager;Trusted_Connection=True;"))
            {
                var sql = @"INSERT INTO Pantry (ID, Name, Ounces, PurchaseDate, CreatedDate, ExpirationDate) VALUES ( @Id, @Name, @Ounces, @PurchaseDate, @CreatedDate, @ExpirationDate)";
                context.Execute(sql, new {@Id = contents.Id, @Name = contents.Name, @Ounces = contents.Ounces, @PurchaseDate = contents.PurchaseDate, @CreatedDate = contents.CreatedDate, @ExpirationDate = contents.ExpirationDate  });
            }
            return Ok();
        }
    }
}
