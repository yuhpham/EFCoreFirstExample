using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFirstExample.Entity
{
    [Table("tbl_product")]
    public class Product
    {
        #region Properties
        [Key]
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public decimal Price { get; set; }
        public int quantity { get; set; }   

        #endregion Properties

        // Navigation property for 1-n relationship with UserOrderProduct
        public List<UserOrderProduct>? UserOrderProducts { get; set; }
      
    }
}
