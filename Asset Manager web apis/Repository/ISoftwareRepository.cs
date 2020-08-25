using System.Collections.Generic;
using System.Linq;

namespace AssetManagement.Models{
    public interface ISoftwareRepository
    {
        Software GetSoftware(int id);
        List<Software> AllSoftware();
        Software Add(Software software);
        Software Delete(int id);
        bool Update(int id,Software softwareChanges);
    }
}
