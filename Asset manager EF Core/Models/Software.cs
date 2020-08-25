using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagement.Models
{
     [Table("Softwares")]

    public class Software
    {        
        [Key]  
        [Required(ErrorMessage="id is required")]
        public string id{get;set;}

        [Required(ErrorMessage="Name is required")]
        public string name{get;set;}
    
        
        [Required(ErrorMessage="provider name is required")]
        public string provider {get;set;}
      
        [Required(ErrorMessage="version is required")]
        public string version{get;set;}
        
        [Required(ErrorMessage="Price is required")]
        public double price{get;set;}
    }
}
