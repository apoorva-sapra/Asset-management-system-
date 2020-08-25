using System.Collections.Generic;
using System.Linq;

namespace AssetManagement.Models{
    public interface IHardwareRepository
    {
        Hardware GetHardware(int Id);
        List<Hardware> AllHardware();
        Hardware Add(Hardware hardware);
        Hardware Delete(int Id);
        bool Update(int id,Hardware hardwareChanges);
    }
}
