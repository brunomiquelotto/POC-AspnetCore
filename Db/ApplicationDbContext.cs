using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Db
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Derivation> Derivations { get; set; }
        public DbSet<Residue> Residues { get; set; }
        public DbSet<Cronogram> Cronogram { get; set;}
        public DbSet<Company> Companies {get;set;}
    }
}