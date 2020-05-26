﻿using SinekliBakkal.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinekliBakkal.DAL
{
    public class SinekliBakkalEntities : DbContext
    {
        public SinekliBakkalEntities() : base("SinekliBakkalConnection")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
