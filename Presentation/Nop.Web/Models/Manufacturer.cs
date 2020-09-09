using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Nop.Web.Models
{
    public class Manufacturer
    {
        [Key] 
	    public int ID { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = " MetaTitle")]
        public string MetaTitle { get; set; }
       
    }
}
