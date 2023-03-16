using IdentityCoreDemo.Migrations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCoreDemo.Models
{
    public class MyDbContext : IdentityDbContext<ApplicationUser>
    {
        //public MyDbContext(DbContextOptions options) : base(options)
        //{

        //}
        public MyDbContext(DbContextOptions<MyDbContext> options)
           : base(options)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<BookTicket> BookTicket { get; set; }
        public virtual DbSet<SignUpModel> SignUpModel { get; set; }
        
    }
}