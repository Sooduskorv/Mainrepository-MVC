﻿using Basket.Infra;
using Microsoft.EntityFrameworkCore;

namespace Basket.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            BasketDbContext.InitializeTables(builder);
        }
    }
}