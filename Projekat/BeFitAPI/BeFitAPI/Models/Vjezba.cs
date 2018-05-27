namespace BeFitAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vjezba")]
    public partial class Vjezba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vjezba()
        {
            VjezbaUProgramu = new HashSet<VjezbaUProgramu>();
        }

        public int Id { get; set; }

        public int MisicnaGrupaId { get; set; }

        public string Naziv { get; set; }

        public string Opis { get; set; }

        public int RedniBrojVjezbe { get; set; }

        public virtual MisicnaGrupa MisicnaGrupa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VjezbaUProgramu> VjezbaUProgramu { get; set; }
    }
}
