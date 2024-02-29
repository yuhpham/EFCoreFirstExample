using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreFirstExample.Entity
{
    [Table("tbl_user_order_product")]
    public class UserOrderProduct
    {
        [Key]
        public int UserOrderProductId { get; set; }
        [Required]
        public string ProductName { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public decimal Discount { get; set; }
        [Required]
        public string Note { get; set; } =string.Empty;

        // Foreign key property for 1-n relationship with UserOrder
        public int UserOrderId { get; set; }
        [Required]
        public UserOrder? UserOrder { get; set; }

      
    }
}
