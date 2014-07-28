namespace CodeFirst_MigratWithExistDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class G5RCNIER
    {
        public G5RCNIER()
        {
            G5RCDZE = new HashSet<G5RCDZE>();
            G5RCLKL = new HashSet<G5RCLKL>();
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

        public long G5RDN { get; set; }

        [Required]
        [StringLength(255)]
        public string G5OPIS { get; set; }

        public long G5UZG { get; set; }

        public long G5WRT { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTW { get; set; }

        [Column(TypeName = "date")]
        public DateTime G5DTU { get; set; }

        [Required]
        [StringLength(30)]
        public string G5RPTW { get; set; }

        [Required]
        [StringLength(30)]
        public string G5ROBCN { get; set; }

        public int? id_G5RCW { get; set; }

        public virtual ICollection<G5RCDZE> G5RCDZE { get; set; }

        public virtual ICollection<G5RCLKL> G5RCLKL { get; set; }

        public virtual G5RCW G5RCW { get; set; }
    }
}
