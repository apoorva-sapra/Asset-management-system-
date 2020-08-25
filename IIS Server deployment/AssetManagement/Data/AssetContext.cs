using Microsoft.EntityFrameworkCore;
using AssetManagement.Models;

namespace AssetManagement.Data{

public class AssetContext:DbContext
{
    public DbSet<Book> Books{get;set;}
    public DbSet<Software> Softwares{get;set;}
    public DbSet<Hardware> Hardwares{get;set;}
    public AssetContext(DbContextOptions<AssetContext> options)
    :base(options)
    { }
}
}