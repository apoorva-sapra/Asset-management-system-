using System.Collections.Generic;
using System.Linq;

namespace AssetManagement.Models{
    public interface ISoftwareRepository
    {
        Software GetSoftware(string Id);
        List<Software> AllSoftware();
        Software Add(Software software);
        Software Delete(string Id);
        Software Update(Software softwareChanges);
    }
}
