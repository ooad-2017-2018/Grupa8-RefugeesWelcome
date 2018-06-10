using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace OOADAspNetMVCEFAzure.Models
{
    public class OOADContext : DbContext
    {
        public OOADContext() : base("AzureConnection") //AzureConnection je naziv connection stringa u Web.config-u
        {
        }
        //dodavanjem klasa iz modela kao DbSet iste će biti mapirane u bazu podataka
        public DbSet<Izbjeglica> Izbjeglica { get; set; }
        public DbSet<Korisnik> Korisnik { get; set; }
        public DbSet<Obrazovanje> Obrazovanje { get; set; }
        public DbSet<TrzisteRada> TrzisteRada { get; set; }
        public DbSet<PravnaProcedura> PravnaProcedura { get; set; }
        public DbSet<Zdravstvo> Zdravstvo { get; set; }
        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    
}
}