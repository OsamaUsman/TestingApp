using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApp.Model
{
    public class Category : IMyEntity
    {
        [Key]
        public long Id { get; set; }

        
        public string Name { get; set; }
        
        
        public string Description { get; set; }
        
        
        public string Status { get; set; }

        public virtual List<Product> Products  { get; set; }

    }
}
