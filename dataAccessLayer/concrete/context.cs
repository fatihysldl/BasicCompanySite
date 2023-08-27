using entityLayer.concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.concrete
{
    public class context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server =FATIH\\SQLEXPRESS; initial catalog=companyDb ;integrated security=true; TrustServerCertificate=True;"); 
        }
        public DbSet<about> abouts { get; set; }
        public DbSet<companyServices> companyServices { get; set; }
        public DbSet<contact> contacts{ get; set; }
    }
}
