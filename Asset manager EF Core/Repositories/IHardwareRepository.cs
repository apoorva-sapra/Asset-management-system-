using System.Collections.Generic;
using System.Linq;

namespace AssetManagement.Models{
    public interface IHardwareRepository
    {
        Hardware GetHardware(string Id);
        List<Hardware> AllHardware();
        Hardware Add(Hardware hardware);
        Hardware Delete(string Id);
        Hardware Update(Hardware hardwareChanges);
    }
}
