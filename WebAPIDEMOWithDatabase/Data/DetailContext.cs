using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIDEMOWithDatabase.Data.Entities;

namespace WebAPIDEMOWithDatabase.Data
{
    public class DetailContext : DbContext
    {
        public DetailContext(DbContextOptions<DetailContext> options) : base(options)
        {
        }
        public DbSet<Detail> Detail { get; set; }

    }
}
