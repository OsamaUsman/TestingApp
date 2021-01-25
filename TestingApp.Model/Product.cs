using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace TestingApp.Model
{
    public class Product : IMyEntity
    {
        [Key]
        public long Id { get; set; }

        [Required (ErrorMessage ="Please Enter Name")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "Please Enter Description")]
        public string Descripton { get; set; }
        
        [Required(ErrorMessage = "Please Enter Price")]
        public decimal Price { get; set; }
        
        [Required(ErrorMessage = "Please Enter Quantity of Product")]
        public int Quantity { get; set; }

        public string ImgPath { get; set; }

        [Required(ErrorMessage = "Please Enter CategoryId")]
        [Display (Name="Category")]
        public long CategoryId { get; set; }
        
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImgFile { get; set; }
    }
}
