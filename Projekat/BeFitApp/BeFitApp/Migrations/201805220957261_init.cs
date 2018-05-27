namespace BeFitApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Korisnik",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Ime = c.String(),
                        Prezime = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        UserAjDi = c.String(),
                        Biografija = c.String(),
                        Lokacija = c.String(),
                        KontaktTelefon = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Program",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                        KlijentId = c.Int(),
                        Cijena = c.Double(),
                        Ocjena = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Trener_Id = c.Int(),
                        Klijent_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisnik", t => t.Trener_Id)
                .ForeignKey("dbo.Korisnik", t => t.Klijent_Id)
                .ForeignKey("dbo.Korisnik", t => t.KlijentId, cascadeDelete: true)
                .Index(t => t.KlijentId)
                .Index(t => t.Trener_Id)
                .Index(t => t.Klijent_Id);
            
            CreateTable(
                "dbo.Komentar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KorisnikId = c.Int(nullable: false),
                        Text = c.String(),
                        TrenerProgram_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Korisnik", t => t.KorisnikId, cascadeDelete: true)
                .ForeignKey("dbo.Program", t => t.TrenerProgram_Id)
                .Index(t => t.KorisnikId)
                .Index(t => t.TrenerProgram_Id);
            
            CreateTable(
                "dbo.MisicnaGrupa",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Naziv = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VezaKorisnikProgram",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KorisnikId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vjezba",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MisicnaGrupaId = c.Int(nullable: false),
                        Naziv = c.String(),
                        Opis = c.String(),
                        RedniBrojVjezbe = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MisicnaGrupa", t => t.MisicnaGrupaId, cascadeDelete: true)
                .Index(t => t.MisicnaGrupaId);
            
            CreateTable(
                "dbo.VjezbaUProgramu",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VjezbaId = c.Int(nullable: false),
                        BrojSetova = c.Int(nullable: false),
                        BrojRepova = c.Int(nullable: false),
                        Vrijeme = c.Time(nullable: false, precision: 7),
                        Dan = c.String(),
                        ProgramId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Vjezba", t => t.VjezbaId, cascadeDelete: true)
                .Index(t => t.VjezbaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.VjezbaUProgramu", "VjezbaId", "dbo.Vjezba");
            DropForeignKey("dbo.Vjezba", "MisicnaGrupaId", "dbo.MisicnaGrupa");
            DropForeignKey("dbo.Program", "KlijentId", "dbo.Korisnik");
            DropForeignKey("dbo.Program", "Klijent_Id", "dbo.Korisnik");
            DropForeignKey("dbo.Komentar", "TrenerProgram_Id", "dbo.Program");
            DropForeignKey("dbo.Komentar", "KorisnikId", "dbo.Korisnik");
            DropForeignKey("dbo.Program", "Trener_Id", "dbo.Korisnik");
            DropIndex("dbo.VjezbaUProgramu", new[] { "VjezbaId" });
            DropIndex("dbo.Vjezba", new[] { "MisicnaGrupaId" });
            DropIndex("dbo.Komentar", new[] { "TrenerProgram_Id" });
            DropIndex("dbo.Komentar", new[] { "KorisnikId" });
            DropIndex("dbo.Program", new[] { "Klijent_Id" });
            DropIndex("dbo.Program", new[] { "Trener_Id" });
            DropIndex("dbo.Program", new[] { "KlijentId" });
            DropTable("dbo.VjezbaUProgramu");
            DropTable("dbo.Vjezba");
            DropTable("dbo.VezaKorisnikProgram");
            DropTable("dbo.MisicnaGrupa");
            DropTable("dbo.Komentar");
            DropTable("dbo.Program");
            DropTable("dbo.Korisnik");
        }
    }
}
