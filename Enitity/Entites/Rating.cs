using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Entites
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }
        [Required]
        public double? RatingA { get; set; } //Rating is member of names so + 'A' მაინტერესებს double რასახით დავსიდო dbcontext-ში

        //add rating seeds .... !!!!!!!!!!!!!


        //ADD RELATIONS 

        //Rating => Product ; one to one => (Rating) to (Product)
       public virtual ICollection<Product>? Products { get; set; } // can we add  + 's' ??? 
        public decimal RatingValue { get; set; }
    }
}
