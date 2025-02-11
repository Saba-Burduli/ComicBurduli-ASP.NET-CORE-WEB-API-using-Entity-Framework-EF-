using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Entites
{
    public class OrderStatus
    {
        [Key]
        public int OrderStatusId { get; set; }

        [Required]
        public string? OrderStatusA { get; set; } 
        //add OrderStatusA seeding !!!!!!!!!!!!!

        //ADD RELATIONS 

        //OrderStatus => Orders ; one to one => (OrderStatus) to (Orders)
        //[ForeignKey("Order")]
        //public int OrderId { get; set; }
        //public virtual Order? Orders { get; set; } 

        // ამის ნაცვლად უნდა გქონდეს ICollection => OrderStatus ბევრი Order შეესაბამება,
        // და 1 order-ს 1 OrderStatus

        public virtual ICollection<Order>? Orders { get; set; }

    }
}
