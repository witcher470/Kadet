using DataTier.Entities.Concrete;
using DataTier.Entities.Concrete.Enums;
using DataTier.Entities.Concrete.Statuses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataTier.Entities.Abstract
{
    public class EFDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<DealerCenter> DealerCenters { get; set; }
        public DbSet<Fillial> Fillials { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<ServiceStation> ServiceStations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<CardStatus> CardStatuses {get;set;}
        public DbSet<ContractorStatus> ContractorStatuses { get; set; }
        public DbSet<CraneManipulatorStatus> CraneManipulatorStatuses { get; set; }
        public DbSet<DealerCenterStatus> DealerCenterStatuses { get; set; }
        public DbSet<FillialStatus> FillialStatuses { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<ServiceStationStatus> ServiceStationStatuses { get; set; }
        public DbSet<ServiceStatus> ServiceStatuses { get; set; }
        public DbSet<TrolleysStatus> TrolleysStatuses { get; set; }
        public DbSet<UserStatus> UserStatuses { get; set; }
        public DbSet<HasFillial> HasFillials { get; set; }
        public DbSet<PaymentMethod> PaymentMethods { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SettlementPeriod> SettlementPeriods { get; set; }
        public DbSet<SettlementType> SettlementTypes { get; set; }
        public DbSet<ClientInfo> ClientInfos { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CarBrand> CarBrands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /* optionsBuilder.UseNpgsql("isilo.db.elephantsql.com;" +
                 "Port=5432;" +
                 "Database=cfioufwh;" +
                 "Username=cfioufwh;" +
                 "Password=ULOgASP7ZK16Dn9xPMGJsuYrR599gTne"); */
            //Server = localhost\SQLEXPRESS; Database = master; Trusted_Connection = True;
        }
        public EFDbContext()
        {
            Database.EnsureCreated();
        }


    }

}
