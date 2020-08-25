using System.Collections.Generic;
using AssetManagement.Models;
namespace AssetManagement.ViewModel
{
    public class AllViewModel{
        public AllViewModel()
        {
            books=new List<Book>();
            hardwares=new List<Hardware>();
            softwares=new List<Software>();

        }
        public List<Book> books{get;set;}
        public List<Hardware> hardwares{get;set;}
        public List<Software> softwares{get;set;}
              
    }
}