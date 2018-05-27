namespace BeFitAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AspModel : DbContext
    {
        public AspModel()
            : base("name=AspModel")
        {
        }

        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<Komentar> Komentar { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<MisicnaGrupa> MisicnaGrupa { get; set; }
        public virtual DbSet<Program> Program { get; set; }
        public virtual DbSet<VezaKorisnikProgram> VezaKorisnikProgram { get; set; }
        public virtual DbSet<Vjezba> Vjezba { get; set; }
        public virtual DbSet<VjezbaUProgramu> VjezbaUProgramu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Program)
                .WithOptional(e => e.Korisnik)
                .HasForeignKey(e => e.Klijent_Id);

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Program1)
                .WithOptional(e => e.Korisnik1)
                .HasForeignKey(e => e.KlijentId)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Korisnik>()
                .HasMany(e => e.Program2)
                .WithOptional(e => e.Korisnik2)
                .HasForeignKey(e => e.Trener_Id);

            modelBuilder.Entity<Program>()
                .HasMany(e => e.Komentar)
                .WithOptional(e => e.Program)
                .HasForeignKey(e => e.TrenerProgram_Id);
        }
    }
}
