using System;
using Xunit;
using AssetManagement.Tests.Mock;
using AssetManagement.Models;
using AssetManagement.Service;

namespace AssetManagement.Tests
{
    public class BookTest
    {
        [Fact]
        //Test case for checking added book
        public void Add_Book_ReturnsTrue()
        {
            var book = new Book() { name = "Python", author = "Guido", edition = "1st", price = 1000 };

            var service = new AssetService<Book>(new MockRepository<Book>());
            var expected = service.Add(book);

            Assert.True(expected == true);
        }

        //test case for checking Deleted book
        [Fact]
        public void Delete_Book_ReturnsTrue()
        {
            var book = new Book() { id = 1, name = "Java", author = "Guido", edition = "1st", price = 1000 };

            var service = new AssetService<Book>(new MockRepository<Book>());
            service.Add(book);

            var expected = service.Delete(book.id);

            Assert.False(expected == null);
        }
        //test case for updating book
        [Fact]
        public void Update_Book_ReturnsTrue()
        {
            var book = new Book() { id = 1, name = "Java", author = "Guido", edition = "1st", price = 1000 };

            var service = new AssetService<Book>(new MockRepository<Book>());
            service.Add(book);
            var bookChanges = service.GetAsset(book.id);
            bookChanges.price = 2000;
            var expected = service.Update(bookChanges);

            Assert.False(expected == null);
        }
        //test case for getting book by id
        [Fact]
        public void GetBookById_ReturnsBook()
        {
            var book = new Book() { name = "Java", author = "Guido", edition = "1st", price = 1000 };

            var service = new AssetService<Book>(new MockRepository<Book>());
            service.Add(book);
            var id = 1;
            var expected = service.GetAsset(id);

            Assert.False(expected == null);
        }
        //test case for getting all book list
        [Fact]
        public void Get_AllBooks_ReturnsBookList()
        {
            var book1 = new Book() { name = "Java", author = "Guido", edition = "1st", price = 1000 };
            var book2 = new Book() { name = "Java", author = "Guido", edition = "1st", price = 1000 };
            var book3 = new Book() { name = "Java", author = "Guido", edition = "1st", price = 1000 };
            var service = new AssetService<Book>(new MockRepository<Book>());

            service.Add(book1);
            service.Add(book2);
            service.Add(book3);

            var expected = service.GetAllAssets();
            Assert.Equal(3, expected.Count);
        }

    }
}
