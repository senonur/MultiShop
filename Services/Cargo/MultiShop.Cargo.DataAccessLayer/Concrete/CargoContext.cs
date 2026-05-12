using Microsoft.EntityFrameworkCore;
using MultiShop.Cargo.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DataAccessLayer.Concrete
{
    public class CargoContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Server=DESKTOP-KLOPUD3;initial Catalog=MultiShopCargoDb;User=sa;Password=123456aA*");
            
            // Eski bağlantıyı yoruma aldık veya silebilirsin
            // optionsBuilder.UseSqlServer("Server=DESKTOP-KLOPUD3;initial Catalog=MultiShopCargoDb;Integrated Security=True;TrustServerCertificate=True;");

            // YENİ DOCKER BAĞLANTISI (Buradaki şifreyi kendi sa şifren ile değiştir)
            optionsBuilder.UseSqlServer("Server=localhost,7087;Initial Catalog=MultiShopCargoDb;User=sa;Password=123456aA*;TrustServerCertificate=True;");
        }
        public DbSet<CargoCompany> CargoCompanies { get; set; }
        public DbSet<CargoDetail> CargoDetails { get; set; }
        public DbSet<CargoCustomer> CargoCustomers { get; set; }
        public DbSet<CargoOperation> CargoOperations { get; set; }
    }
}
