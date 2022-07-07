using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using redpostgres03.Models;

namespace redpostgres03.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<redpostgres03.Models.Person> Person { get; set; }
        public DbSet<redpostgres03.Models.User> User { get; set; }
    }
}
