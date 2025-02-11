using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Entites
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(20,ErrorMessage = "CategoryName is more than 20 letter")]
        public string? CategoryName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Description is more than 50 letter")]
        public string? Description { get; set; }

        //ADD RELATIONS
        
        // Category => Product ; one to many => (Category) to (Product)
        public virtual ICollection<Product>? Products { get; set; }// can we add  + 's' ??? 
    }
}
