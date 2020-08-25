using System.Collections.Generic;
using AssetManagement.Models;
using AssetManagement.Repository;

namespace AssetManagement.Service
{
    public class BookService : AssetService<Book>
    {
      
        public BookService(IAssetRepository<Book> repository) : base(repository)
        {
           
        }

    }

}