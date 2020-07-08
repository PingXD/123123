﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace StoreSystem.Model
{


    public class StoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;User Id=root;Database=storesystem_db");
        }

        public StoreContext() 
        {
        }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }


        public DbSet<Goods> Goodses { get; set; }
        public DbSet<GoodsClass> GoodsClasses { get; set; }
        public DbSet<GoodsClassMaster> GoodsClassMasters { get; set; }
        public DbSet<IndexViewData> IndexViewDatas  { get; set; }
        public DbSet<Location> Locations  { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserStore>  UserStores { get; set; }




}}
