﻿using Microsoft.EntityFrameworkCore;
using SyncAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            
        }

        public DbSet<SyncIdentifier> SyncIdentifiers { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
    }
}