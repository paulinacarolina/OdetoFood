using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression("*")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name= "Type of Food")]
        public CuisineType  Cuisine { get; set; }
    }
}
