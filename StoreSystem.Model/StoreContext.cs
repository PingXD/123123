using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreSystem.Model
{

    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Goods> Goodses { get; set; }
        public DbSet<GoodsClass> GoodsClasses { get; set; }
        public DbSet<GoodsClassMaster> GoodsClassMasters { get; set; }
        public DbSet<IndexViewData> IndexViewDatas  { get; set; }
        public DbSet<Location> Locations  { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserStore>  UserStores { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

        }
    }
   

}
