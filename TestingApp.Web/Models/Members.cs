using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Model
{
    public class Members
    {
        public long Id { get; set; }


        [Required(ErrorMessage = "Please First Enter UserName")]
        
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Password")]
        
        public string Password { get; set; }
    }
}
