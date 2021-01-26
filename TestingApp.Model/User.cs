using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Model
{
    public class User : IMyEntity
    {
        [Key]
        public long Id { get; set; }

        
        [Required (ErrorMessage ="Please First Enter UserName")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        [StringLength(50)]
        public string Password { get; set; }
    }
}
