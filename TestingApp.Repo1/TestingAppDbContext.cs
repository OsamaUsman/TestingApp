﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingApp.Model;

namespace TestingApp.Repo1
{
    public class TestingAppDbContext : DbContext
    {
        public TestingAppDbContext():base("conn")
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
