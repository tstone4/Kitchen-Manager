using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen_Manager.Models
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
