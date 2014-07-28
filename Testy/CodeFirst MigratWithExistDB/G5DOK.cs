namespace CodeFirst_MigratWithExistDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class G5DOK
    {
        public G5DOK()
        {
            G5RCW = new HashSet<G5RCW>();
        }

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

        public long G5KDK { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTD { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTP { get; set; }

        [Required]
        [StringLength(128)]
        public string G5SYG { get; set; }

        [Required]
        [StringLength(128)]
        public string G5NSR { get; set; }

        [Required]
        [StringLength(128)]
        public string G5OPD { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTW { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTU { get; set; }

        public virtual ICollection<G5RCW> G5RCW { get; set; }
    }
}
