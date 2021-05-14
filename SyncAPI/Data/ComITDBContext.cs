using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SyncAPI.Data
{
    public class ComITDBContext : DbContext
    {
        public ComITDBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
    }
}
