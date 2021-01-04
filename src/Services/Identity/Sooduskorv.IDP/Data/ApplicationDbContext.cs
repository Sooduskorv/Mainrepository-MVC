﻿using Identity.Infra.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Sooduskorv.IDP.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            IdentityDbContext.InitializeTables(builder);
        }
    }
}