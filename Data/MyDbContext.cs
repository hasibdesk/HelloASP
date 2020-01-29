using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloASP.Models;
using Microsoft.EntityFrameworkCore;

namespace HelloASP.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
