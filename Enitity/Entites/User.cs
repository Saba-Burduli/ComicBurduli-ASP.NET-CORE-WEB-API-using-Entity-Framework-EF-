using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Entites
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(20, ErrorMessage = "First name cannot be longer than 20 characters.")]
        public string? UserName { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Password cannot be longer than 20 characters.")]
        public string? PasswordHash{ get; set; }
        
        [EmailAddress]
        [MaxLength(20, ErrorMessage = "Email cannot be longer than 20 characters.")]
        public string? Email { get; set; } 

        //User => Role ; Many to Many
        [ForeignKey("Role")]
        public int RoleId { get; set; }    
        public virtual ICollection<Role>? Roles { get; set; }
        
        
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person? Person { get; set; } 
        
        
    }
}
