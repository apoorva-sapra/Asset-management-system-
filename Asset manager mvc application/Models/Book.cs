using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AssetManagement.Models
{
    public class Book:Asset
    {           
        [Required(ErrorMessage="id is required")]
        public string id{get;set;}

        [Required(ErrorMessage="Name is required")]
        public string name{get;set;}



        [Required(ErrorMessage="Author name is required")]
        public string author{get;set;}
      
        [Required(ErrorMessage="Edition is required")]
        public string edition{get;set;}
        [Required(ErrorMessage="Price is required")]
        public double price{get;set;}     
    }
}
