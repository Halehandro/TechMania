using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }

        public DbSet<SmartPhone> SmartPhones { get; set; }
        public DbSet<SmartPhoneImage> SmartPhoneImages { get; set; }
        public DbSet<Addition> Additions { get; set; }
        public DbSet<SmartPhoneOrderDetails> SmartPhoneOrderDetails { get; set; }
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
    }
}
