using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Entites
{
    public class Order                                                                                                                  
    {
        [Key]
        public int OrderId { get; set; }

        [MaxLength(20, ErrorMessage = "Ordername is more than 20")]
        public string? Ordername { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }


        //ADD RELATIONS 
        // Order => PaymentType
        [ForeignKey("PaymentType")]
        public int PaymentId { get; set; }
        public virtual PaymentType? PaymentType { get; set; }

        //Order => Person
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person? Person { get; set; }

        //Order => OrderStatus
        [ForeignKey("OrderStatus")]
        public int OrderStatusId { get; set; }
        public virtual OrderStatus? OrderStatus { get; set; }

        //Order => OrderItems
        public virtual ICollection<OrderItem>? OrderItems { get; set; }  
    }
}
