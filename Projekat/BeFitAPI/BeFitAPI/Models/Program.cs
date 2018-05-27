namespace BeFitAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Program")]
    public partial class Program
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Program()
        {
            Komentar = new HashSet<Komentar>();
        }

        public int Id { get; set; }

        public string Naziv { get; set; }

        public int? KlijentId { get; set; }

        public double? Cijena { get; set; }

        public double? Ocjena { get; set; }

        [Required]
        [StringLength(128)]
        public string Discriminator { get; set; }

        public int? Trener_Id { get; set; }

        public int? Klijent_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Komentar> Komentar { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Korisnik Korisnik2 { get; set; }
    }
}
