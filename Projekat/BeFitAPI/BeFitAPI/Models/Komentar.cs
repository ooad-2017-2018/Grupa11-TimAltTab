namespace BeFitAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Komentar")]
    public partial class Komentar
    {
        public int Id { get; set; }

        public int KorisnikId { get; set; }

        public string Text { get; set; }

        public int? TrenerProgram_Id { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Program Program { get; set; }
    }
}
