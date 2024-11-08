using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorFullStackCrud.Shared
{
    public class Product
    {
        public int Id {get; set;}
        public string Code {get; set;}
        public string ProductName {get; set;}
        public string ProductDescribe { get; set;}
        public string Supplier { get; set; }
        public int MinimumStock { get; set; }
        public int Stock { get; set; }
        public int Prohibited { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PurchaseValue { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal UnitaryValue{ get; set; }

        [Column(TypeName = "decimal(18,2)")]     
        public decimal SaleValue { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Profit { get; set; }

        public DateTime DatePurchase { get; set; }

        

        public Category? Category { get; set; }
        public int CategoryId { get; set; }


    }
}
