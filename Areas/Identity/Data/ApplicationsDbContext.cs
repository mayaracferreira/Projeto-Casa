using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CasaShow.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CasaShow.Data
{
    public class ApplicationsDbContext : IdentityDbContext<IdentityUser>
    {       
        
        public DbSet <Show> Shows {get;set;}
        public DbSet <Evento> Eventos {get;set;}

        public DbSet <Casa> Casas {get;set;}

        public DbSet <Ingresso> Ingressos {get;set;}
        public ApplicationsDbContext(DbContextOptions<ApplicationsDbContext> options)
            : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
