using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace AssetManagement.Models
{
    public class Hardware:Asset
    {        
                 
        [Required(ErrorMessage="id is required")]
        public string id{get;set;}

        [Required(ErrorMessage="Name is required")]
        public string name{get;set;}
       
       
        [Required(ErrorMessage="Brand name is required")]
        public string brand{get;set;}
      
        [Required(ErrorMessage="Model is required")]
        public string model{get;set;}
        
        [Required(ErrorMessage="Price is required")]
        public double price{get;set;}
    }
}
