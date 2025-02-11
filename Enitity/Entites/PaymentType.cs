using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Entites
{
    public class PaymentType
    {
        [Key]
        public int PaymentTypeId { get; set; }

        [Required]
        [MaxLength(20,ErrorMessage = "PaymentName is more than 20 letter")]
        public string? PaymentName { get; set; }

        //ADD RELATIONS 
        public virtual ICollection<Order>? Orders { get; set; }
    }
}
