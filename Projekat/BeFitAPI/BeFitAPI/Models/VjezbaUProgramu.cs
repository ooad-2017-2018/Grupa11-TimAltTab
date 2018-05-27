namespace BeFitAPI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VjezbaUProgramu")]
    public partial class VjezbaUProgramu
    {
        public int Id { get; set; }

        public int VjezbaId { get; set; }

        public int BrojSetova { get; set; }

        public int BrojRepova { get; set; }

        public TimeSpan Vrijeme { get; set; }

        public string Dan { get; set; }

        public int ProgramId { get; set; }

        public virtual Vjezba Vjezba { get; set; }
    }
}
