namespace CodeFirst_MigratWithExistDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class G5RCBUD
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

        [Required]
        [StringLength(128)]
        public string G5IDB { get; set; }

        public long G5FPB { get; set; }

        public long G5FDB { get; set; }

        public long G5UZI { get; set; }

        public long G5UZD { get; set; }

        [Required]
        [StringLength(128)]
        public string G5LL { get; set; }

        public long G5WRT { get; set; }

        public float G5PEU { get; set; }

        [Required]
        [StringLength(128)]
        public string G5RZ { get; set; }

        public long G5RPB { get; set; }

        [Required]
        [StringLength(32)]
        public string G5UD { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTW { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTU { get; set; }

        [Required]
        [StringLength(30)]
        public string G5RADR { get; set; }

        [Required]
        [StringLength(30)]
        public string G5RSKL { get; set; }
    }
}
