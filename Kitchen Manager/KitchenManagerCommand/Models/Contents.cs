using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenManagerCommand.Models
{
    public class Contents
    {
        //Server=localhost;Database=KitchenManager;Trusted_Connection=True;
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Ounces { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
