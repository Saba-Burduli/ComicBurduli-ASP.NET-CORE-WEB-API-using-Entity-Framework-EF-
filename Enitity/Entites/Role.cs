using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace SalesManagementSystem.DATA.Entites
{
    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "The name is too long.")]
        public string? RoleName { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "The description is too long.")]
        public string? RoleDescription { get; set; }

        //Role => User
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual ICollection<User>? Users { get; set; }
        
    }
}
