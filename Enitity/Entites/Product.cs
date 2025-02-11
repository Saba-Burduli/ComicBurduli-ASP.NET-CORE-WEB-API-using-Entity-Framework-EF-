using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Entites
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }


        [MaxLength(20, ErrorMessage = "ProductName is more than 20 letter")]
        public string? ProductName { get; set; }
        
        public double? Price { get; set; }

        public int StockQuantity { get; set; }


        //ADD RELATIONS 

        //Rating => Product ; one to one => (Rating) to (Product)   
        [ForeignKey("Rating")]
        public int RatingId { get; set; }
        public virtual Rating? Ratings { get; set; } // can we add  + 's' ??? 

        //Product => Category ; one to one => (Product) to (Category)
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }

        // Product => OrderItems
        public virtual ICollection<OrderItem>? OrderItems { get; set; }
        
    }
}
