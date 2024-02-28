using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreFirstExample.Entity
{
    [Table("tbl_user_order_product")]
    public class UserOrderProduct
    {
        [Key]
        public int UserOrderProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;

        // Foreign key property for 1-n relationship with UserOrder
        public int UserOrderId { get; set; }
        public UserOrder? UserOrder { get; set; }

        // Foreign key property for 1-n relationship with Product
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
