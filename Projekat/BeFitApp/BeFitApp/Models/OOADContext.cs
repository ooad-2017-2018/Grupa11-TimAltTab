using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace BeFitApp.Models
{
    public class OOADContext : DbContext
    {
        public OOADContext() : base("AzureConnection") //AzureConnection je naziv connection stringa u Web.config-u
        {
        }
        //dodavanjem klasa iz modela kao DbSet iste će biti mapirane u bazu podataka

        //Ova funkcija se koriste da bi se ukinulo automatsko dodavanje množine u nazive
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<BeFitApp.Models.Admin> Admins { get; set; }

        public System.Data.Entity.DbSet<BeFitApp.Models.Korisnik> Korisniks { get; set; }

        public System.Data.Entity.DbSet<BeFitApp.Models.MisicnaGrupa> MisicnaGrupas { get; set; }

        public System.Data.Entity.DbSet<BeFitApp.Models.Vjezba> Vjezbas { get; set; }

        public System.Data.Entity.DbSet<BeFitApp.Models.VjezbaUProgramu> VjezbaUProgramus { get; set; }

        public System.Data.Entity.DbSet<BeFitApp.Models.Program> Programs { get; set; }
        public System.Data.Entity.DbSet<BeFitApp.Models.Trener> Trener { get; set; }
        public System.Data.Entity.DbSet<BeFitApp.Models.Klijent> Klijent { get; set; }

        public System.Data.Entity.DbSet<BeFitApp.Models.Komentar> Komentars { get; set; }

        public System.Data.Entity.DbSet<BeFitApp.Models.VezaKorisnikProgram> VezaKorisnikProgram { get; set; }

    }
}