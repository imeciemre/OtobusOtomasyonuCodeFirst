using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OtobusDBContext : DbContext
    {
        public OtobusDBContext():base("cstr")
        {

        }
        public DbSet<Personel>Personeler { get; set; }
        public DbSet<Görev> Görevlerler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personel>().ToTable("tblPersoneller");

            modelBuilder.Entity<Personel>().Property(p => p.Ad).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Personel>().Property(p => p.Soyad).HasMaxLength(20).IsRequired().HasColumnType("varchar");
            modelBuilder.Entity<Personel>().Property(p => p.TelfonNo).HasMaxLength(20).IsRequired().HasColumnType("varchar");

            modelBuilder.Entity<Görev>().ToTable("tblGörevler");
            modelBuilder.Entity<Görev>().Property(g => g.GörevAd).HasMaxLength(20).IsRequired().HasColumnType("varchar");

        }

    }
}
