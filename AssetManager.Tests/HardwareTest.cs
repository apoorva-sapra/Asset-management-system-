using System;
using Xunit;
using AssetManagement.Tests.Mock;
using AssetManagement.Models;
using AssetManagement.Service;

namespace AssetManagement.Tests
{
    public class HardwareTest
    {
        [Fact]
        //Test case for hardware added
        public void Add_Hardware_ReturnsTrue()
        {
            var hardware = new Hardware() { id = 1, name = "laptop", brand = "hp", model = "hp231", price = 10000 };

            var service = new AssetService<Hardware>(new MockRepository<Hardware>());
            var expected = service.Add(hardware);

            Assert.True(expected == true);
        }

        //test case for deleted hardware
        [Fact]
        public void Delete_Hardware_ReturnsTrue()
        {
            var hardware = new Hardware() { id = 1, name = "laptop", brand = "hp", model = "hp231", price = 10000 };

            var service = new AssetService<Hardware>(new MockRepository<Hardware>());
            service.Add(hardware);

            var expected = service.Delete(hardware.id);

            Assert.False(expected == null);
        }
        //test case for updated hardware
        [Fact]
        public void Update_Hardware_ReturnsTrue()
        {
            var hardware = new Hardware() { id = 1, name = "laptop", brand = "hp", model = "hp231", price = 10000 };

            var service = new AssetService<Hardware>(new MockRepository<Hardware>());
            service.Add(hardware);
            var hardwareChanges = service.GetAsset(hardware.id);
            hardwareChanges.price = 2000;
            var expected = service.Update(hardwareChanges);

            Assert.False(expected == null);
        }
        //test case for getting hardware by id
        [Fact]
        public void GetHardwareById_ReturnsHardware()
        {
            var hardware = new Hardware() { name = "Monitor", model = "intel23", brand = "intel", price = 10000 };
            var service = new AssetService<Hardware>(new MockRepository<Hardware>());
            service.Add(hardware);
            var id = 1;
            var expected = service.GetAsset(id);
            Assert.False(expected == null);
        }
        //test case for checking list of all hardware
        [Fact]
        public void Get_AllHardwares_ReturnsHardwareList()
        {
            var hardware1 = new Hardware() { name = "laptop", model = "hp12", brand = "hp", price = 120000 };
            var hardware2 = new Hardware() { name = "laptop", model = "hp123", brand = "hp", price = 100000 };
            var hardware3 = new Hardware() { name = "monitor", model = "hp1234", brand = "hp", price = 30000 };
            var service = new AssetService<Hardware>(new MockRepository<Hardware>());

            service.Add(hardware1);
            service.Add(hardware2);
            service.Add(hardware3);

            var expected = service.GetAllAssets();
            Assert.Equal(3, expected.Count);
        }

    }
}
