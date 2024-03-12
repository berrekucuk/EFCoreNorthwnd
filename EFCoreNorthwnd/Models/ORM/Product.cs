using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreNorthwnd.Models.ORM
{
    public class Product : BaseModel
    {
        public string ProductName { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }
        public int? ReoderLevel { get; set; }
        public bool? Discontinued { get; set; }
        public int? SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
