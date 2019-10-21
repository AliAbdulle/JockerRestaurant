using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using JockerRestaurant.Models;

namespace JockerRestaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<JockerRestaurant.Models.Restaurant> Restaurant { get; set; }
        public DbSet<JockerRestaurant.Models.Menu> Menu { get; set; }
    }
}
