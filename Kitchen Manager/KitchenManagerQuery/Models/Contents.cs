using System;
using System.Collections.Generic;
using System.Text;

namespace KitchenManagerQuery.Models
{
    public class Contents
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Ounces { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
