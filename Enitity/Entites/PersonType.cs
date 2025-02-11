using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagementSystem.DATA.Entites
{
    public class PersonType
    {
        [Key]
        public int PersontypeId { get; set; }
        [MaxLength(30,ErrorMessage = "Name must be less than 30 characters. ")]
        public string? PersonTypeName { get; set; } //add seeding  +A for 
        [MaxLength(50, ErrorMessage = "Name must be less than 50 characters. ")]
        public string? PersonTypeDescription { get; set; }
        //PersonType => Person
        public virtual ICollection<Person>? Persons { get; set; }
    }
}
