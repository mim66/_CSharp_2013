namespace CodeFirst_MigratWithExistDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class G5ADR
    {
        public int id { get; set; }

        [Required]
        [StringLength(2)]
        public string typBaz { get; set; }

        [Required]
        [StringLength(30)]
        public string idO { get; set; }

        [Required]
        [StringLength(30)]
        public string idR { get; set; }

        [Required]
        [StringLength(2)]
        public string st_obj { get; set; }

        public long G5TAR { get; set; }

        [Required]
        [StringLength(128)]
        public string G5NAZ { get; set; }

        [Required]
        [StringLength(128)]
        public string G5ULC { get; set; }

        [Required]
        [StringLength(128)]
        public string G5NRA { get; set; }

        [Required]
        [StringLength(128)]
        public string G5NRL { get; set; }

        [Required]
        [StringLength(128)]
        public string G5MSC { get; set; }

        [Required]
        [StringLength(128)]
        public string G5KOD { get; set; }

        [Required]
        [StringLength(128)]
        public string G5PCZ { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTW { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTU { get; set; }
    }
}
