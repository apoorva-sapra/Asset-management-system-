using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace AssetManagement.Models
{
public abstract class Asset
{
        public static List<Book> BookList = new List<Book>();
        
        public static List<Hardware> HardwareList = new List<Hardware>();
        
        public static List<Software> SoftwareList = new List<Software>();

}
}