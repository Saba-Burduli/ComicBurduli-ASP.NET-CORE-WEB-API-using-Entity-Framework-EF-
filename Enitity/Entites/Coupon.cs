using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Entites
{
    public class Coupon
    {
        [Key]
        public int CouponId { get; set; }
        [Required]
        public string? CouponCode { get; set; }
        [Required]
        public double? DiscountAmount { get; set; }
        [Required]
        public bool? IsActive { get; set; }

        //როგორ ავამუშვო Coupon ?? ასევე მჭირდება ცალკე კლასი სადაც
        //უშვალოდ ფუნქციას გავაკეთებ და invoke ით გამოვიძახებ controler -ში

    }
}
