namespace BeFitAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VezaKorisnikProgram")]
    public partial class VezaKorisnikProgram
    {
        public int Id { get; set; }

        public int KorisnikId { get; set; }

        public int ProgramId { get; set; }
    }
}
