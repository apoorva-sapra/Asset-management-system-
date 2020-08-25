using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ConsumeWebApi.Models
{

    public class Book
    {  
            
        [Required(ErrorMessage="id is required")]
        public int id{get;set;}

        [Required(ErrorMessage="Name is required")]
        public string name{get;set;}

        [Required(ErrorMessage="Author name is required")]
        public string author{get;set;}
        
        [Required(ErrorMessage="Edition is required")]
        public string edition{get;set;}
        [Required(ErrorMessage="Price is required")]
        public double price{get;set;}    
        public readonly string assetType="Book";
         
    }
}