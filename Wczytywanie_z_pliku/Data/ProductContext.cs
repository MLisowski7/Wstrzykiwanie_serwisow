﻿using Wczytywanie_z_pliku.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wczytywanie_z_pliku.Pages;

namespace Wczytywanie_z_pliku.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions options) : base(options) { }
        public DbSet<Product> Product { get; set; }

    }
}
