using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OdeToFood.Data
{
    public class OdeToFoodDbContext: DbContext
    {
        private readonly DbContextOptions<OdeToFoodDbContext> options;

        public OdeToFoodDbContext(DbContextOptions<OdeToFoodDbContext> options): base(options)
        {
            this.options = options;
        }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
