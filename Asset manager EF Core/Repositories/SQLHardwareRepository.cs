using System.Collections.Generic;
using System;
using System.Linq;
using AssetManagement.Data;

namespace AssetManagement.Models{

public class SQLHardwareRepository : IHardwareRepository
{
    private readonly AssetContext context;

    public SQLHardwareRepository(AssetContext context)
    {
        this.context = context;
    }
        
        public List<Hardware> AllHardware()
        {
            return context.Hardwares.AsEnumerable().ToList();
        }
        public Hardware Add(Hardware hardware)
    {
        context.Hardwares.Add(hardware);
        context.SaveChanges();
        return hardware;
    }

    public Hardware Delete(string Id)
    {
        Hardware hardware = context.Hardwares.Find(Id);
        if (hardware != null)
        {
            context.Hardwares.Remove(hardware);
            context.SaveChanges();
        }
        return hardware;
    }

    public Hardware GetHardware(string Id)
    {
        return context.Hardwares.Find(Id);
    }
    public Hardware Update(Hardware hardwareChanges)
    {
        var hardware = context.Hardwares.Attach(hardwareChanges);
        hardware.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        context.SaveChanges();
        return hardwareChanges;
    }
}
}