using System;
using Xunit;
using AssetManagement.Tests.Mock;
using AssetManagement.Models;
using AssetManagement.Service;

namespace AssetManagement.Tests
{
    public class SoftwareTest
    {
        [Fact]
        //Test case for software added
        public void Add_Software_ReturnsTrue()
        {
             var software= new Software(){name="Antivirus",provider="Avast",version="av1",price=1500};

            var service= new AssetService<Software>(new MockRepository<Software>());
            var expected=service.Add(software);

            Assert.True(expected==true);
        } 
       
        //test case for deleted software
        [Fact]
        public void Delete_Software_ReturnsTrue()
        {
             var software= new Software(){id=1,name="Antivirus",provider="Avast",version="av1",price=1500};
           
            var service= new AssetService<Software>(new MockRepository<Software>());
            service.Add(software);
          
            var expected=service.Delete(software.id);

            Assert.False(expected==null);
        } 
        //test case for updated software
         [Fact]
        public void Update_Software_ReturnsTrue()
        {
            var software= new Software(){id=1,name="Antivirus",provider="Avast",version="av1",price=1500};
           
            var service= new AssetService<Software>(new MockRepository<Software>());
            service.Add(software);
            var softwareChanges=service.GetAsset(software.id);
            softwareChanges.price=2000;
            var expected=service.Update(softwareChanges);

            Assert.False(expected==null);
        } 
        //test case for getting software by id
        [Fact]
         public void GetSoftwareById_ReturnsSoftware()
        {
            var software= new Software(){name="Antivirus",provider="Avast",version="av1",price=1500};
            var service= new AssetService<Software>(new MockRepository<Software>());
            service.Add(software);
            var id=1;
            var expected=service.GetAsset(id);
            Assert.False(expected==null);
        } 
         //test case for checking list of all software
        [Fact]
        public void Get_AllSoftwares_ReturnsSoftwareList()
        {
            var software1 = new Software() { name = "Antivirus", provider = "Avast", version = "1st", price = 1200};
            var software2 = new Software() { name = "Wordpad", provider = "MS Office", version = "3rd", price = 1000};
            var software3 = new Software() { name = "Antivirus", provider = "Avast", version = "2nd", price = 3000};
            var service = new AssetService<Software>(new MockRepository<Software>());

            service.Add(software1);
            service.Add(software2);
            service.Add(software3);

            var expected = service.GetAllAssets();
            Assert.Equal(3, expected.Count);
        }

        
    }
}
