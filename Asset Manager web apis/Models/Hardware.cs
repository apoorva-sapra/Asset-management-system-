
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetManagement.Models
{
    [Table("Hardwares")]
    public class Hardware
    {        
        [Key]      
        [Required(ErrorMessage="id is required")]
        public int id{get;set;}

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
