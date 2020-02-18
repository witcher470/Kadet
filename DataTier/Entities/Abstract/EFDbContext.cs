using DataTier.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Abstract
{
    public class EFDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Contractor>Contractors { get; set; }
        public DbSet<DealerCenter> DealerCenters { get; set; }
        public DbSet<Fillial> Fillials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ServiceStation> ServiceStations { get; set; }
        public DbSet<User> Users { get;set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=userappdb;Trusted_Connection=True;");
        }

    }

}
