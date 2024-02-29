using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreFirstExample.Entity
{
    [Table("tbl_user_order")]
    public class UserOrder
    {
        #region Properties
        [Key]
        public int UserOrderId { get; set; }
        public string TransactionStatus { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        #endregion Properties


        // Foreign key for the 1-n relationship with User
        public int UserId { get; set; }
        public User? User { get; set; }


        // Navigation property for 1-n relationship with UserOrderProduct
        public List<UserOrderProduct>? UserOrderProducts { get; set; }

    }
}
