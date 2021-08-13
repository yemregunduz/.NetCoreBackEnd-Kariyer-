
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class KariyerNetContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.; Database=KariyerNetDb;Trusted_Connection= true");
        }
        public DbSet<Aday> ADAYLAR { get; set; }
        public DbSet<AdayTecrube> ADAYTECRUBELERI { get; set; }
        public DbSet<Bolum> BOLUMLER { get; set; }
        public DbSet<Cv> CVLER { get; set; }
        public DbSet<Ilan> ILANLAR { get; set; }
        public DbSet<Isveren> ISVERENLER { get; set; }
        public DbSet<Okul> OKULLAR { get; set; }
        public DbSet<Pozisyon> POZISYONLAR { get; set; }
        public DbSet<Sehir> SEHIRLER { get; set; }
        public DbSet<Sirket> SIRKETLER { get; set; }
        public DbSet<SistemPersonel> SISTEMPERSONELLERI { get; set; }
        public DbSet<OkulBolum> OKULBOLUM { get; set; }
        public DbSet<AdayOkulBolum> ADAYOKULBOLUM { get; set; }
        public DbSet<Takip> TAKIPLER { get; set; }
        public DbSet<Yetenek> YETENEKLER { get; set; }
        public DbSet<YetenekTip> YETENEKTIPLERI { get; set; }
        public DbSet<AdayYetenek> ADAYYETENEKLER { get; set; }
        public DbSet<Gonderi> GONDERILER { get; set; }
        public DbSet<Yorum> YORUMLAR { get; set; }
        public DbSet<Begeni> BEGENILER { get; set; }


    }
}
