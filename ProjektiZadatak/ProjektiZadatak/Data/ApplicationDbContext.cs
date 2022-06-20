using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjektniZadatak.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjektiZadatak.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Radnik> Radnici { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
