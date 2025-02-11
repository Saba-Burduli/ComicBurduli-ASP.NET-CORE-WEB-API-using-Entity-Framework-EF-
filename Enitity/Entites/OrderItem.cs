using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Entites
{
    public class OrderItem
    {
        [Key]
        public int OrderItemId { get; set; }

        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal ItemPrice { get; set; }

        //ADD RELATIONS 

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }

        //OrderItem => Order
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public virtual Order? Order { get; set; }    
    }
}
