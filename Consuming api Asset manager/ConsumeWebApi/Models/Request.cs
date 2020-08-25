using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ConsumeWebApi.Models
{
      [Table("Requests")]
    public class Request
    {  
        // public Request()
        // {
        //     requestStatus=RequestType.Unassigned;
        // }
        public int requestId{get;set;}
            
        public int assetId{get;set;}
        public string assetType {get;set;}
        public string userId{get;set;}
        public string requestStatus{get;set;}

         
    }
}