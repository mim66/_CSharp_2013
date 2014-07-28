namespace CodeFirst_MigratWithExistDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class G5RCW
    {
        public G5RCW()
        {
            G5RCNIER = new HashSet<G5RCNIER>();
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

        [Required]
        [StringLength(128)]
        public string G5IRCW { get; set; }

        public long G5ROW { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTD { get; set; }

        public long G5FOB { get; set; }

        [Required]
        [StringLength(128)]
        public string G5NRPR { get; set; }

        public long G5CSZ { get; set; }

        public long G5STS { get; set; }

        public long G5STK { get; set; }

        public long G5WRT { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTW { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTU { get; set; }

        [Required]
        [StringLength(30)]
        public string G5RDOK { get; set; }

        public int? id_G5DOK { get; set; }

        public virtual G5DOK G5DOK { get; set; }

        public virtual ICollection<G5RCNIER> G5RCNIER { get; set; }
    }
}
