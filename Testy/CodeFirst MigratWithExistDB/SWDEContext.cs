namespace CodeFirst_MigratWithExistDB
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;

	public partial class SWDEContext : DbContext
	{
		public SWDEContext()
			: base("name=SWDEContext")
		{
		}

		public virtual DbSet<G5ADR> G5ADR { get; set; }
		public virtual DbSet<G5DOK> G5DOK { get; set; }
		public virtual DbSet<G5RCBUD> G5RCBUD { get; set; }
		public virtual DbSet<G5RCDZE> G5RCDZE { get; set; }
		public virtual DbSet<G5RCLKL> G5RCLKL { get; set; }
		public virtual DbSet<G5RCNIER> G5RCNIER { get; set; }
		public virtual DbSet<G5RCOBC> G5RCOBC { get; set; }
		public virtual DbSet<G5RCW> G5RCW { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<G5ADR>()
					.Property(e => e.typBaz)
					.IsUnicode(false);

			modelBuilder.Entity<G5ADR>()
					.Property(e => e.idO)
					.IsUnicode(false);

			modelBuilder.Entity<G5ADR>()
					.Property(e => e.idR)
					.IsUnicode(false);

			modelBuilder.Entity<G5ADR>()
					.Property(e => e.st_obj)
					.IsUnicode(false);

			modelBuilder.Entity<G5ADR>()
					.Property(e => e.G5NAZ)
					.IsUnicode(false);

			modelBuilder.Entity<G5ADR>()
					.Property(e => e.G5ULC)
					.IsUnicode(false);

			modelBuilder.Entity<G5ADR>()
					.Property(e => e.G5NRA)
					.IsUnicode(false);

			modelBuilder.Entity<G5ADR>()
					.Property(e => e.G5NRL)
					.IsUnicode(false);

			modelBuilder.Entity<G5ADR>()
					.Property(e => e.G5MSC)
					.IsUnicode(false);

			modelBuilder.Entity<G5ADR>()
					.Property(e => e.G5KOD)
					.IsUnicode(false);

			modelBuilder.Entity<G5ADR>()
					.Property(e => e.G5PCZ)
					.IsUnicode(false);

			modelBuilder.Entity<G5DOK>()
					.Property(e => e.typBaz)
					.IsUnicode(false);

			modelBuilder.Entity<G5DOK>()
					.Property(e => e.idO)
					.IsUnicode(false);

			modelBuilder.Entity<G5DOK>()
					.Property(e => e.idR)
					.IsUnicode(false);

			modelBuilder.Entity<G5DOK>()
					.Property(e => e.st_obj)
					.IsUnicode(false);

			modelBuilder.Entity<G5DOK>()
					.Property(e => e.G5SYG)
					.IsUnicode(false);

			modelBuilder.Entity<G5DOK>()
					.Property(e => e.G5NSR)
					.IsUnicode(false);

			modelBuilder.Entity<G5DOK>()
					.Property(e => e.G5OPD)
					.IsUnicode(false);

			modelBuilder.Entity<G5DOK>()
					.HasMany(e => e.G5RCW)
					.WithOptional(e => e.G5DOK)
					.HasForeignKey(e => e.id_G5DOK);

			modelBuilder.Entity<G5RCBUD>()
					.Property(e => e.typBaz)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCBUD>()
					.Property(e => e.idO)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCBUD>()
					.Property(e => e.idR)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCBUD>()
					.Property(e => e.st_obj)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCBUD>()
					.Property(e => e.G5IDB)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCBUD>()
					.Property(e => e.G5LL)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCBUD>()
					.Property(e => e.G5RZ)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCBUD>()
					.Property(e => e.G5UD)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCBUD>()
					.Property(e => e.G5RADR)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCBUD>()
					.Property(e => e.G5RSKL)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCDZE>()
					.Property(e => e.typBaz)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCDZE>()
					.Property(e => e.idO)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCDZE>()
					.Property(e => e.idR)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCDZE>()
					.Property(e => e.st_obj)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCDZE>()
					.Property(e => e.G5IDD)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCDZE>()
					.Property(e => e.G5FDZ)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCDZE>()
					.Property(e => e.G5RZ)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCDZE>()
					.Property(e => e.G5UD)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCDZE>()
					.Property(e => e.G5RADR)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCDZE>()
					.Property(e => e.G5RSKL)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCLKL>()
					.Property(e => e.typBaz)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCLKL>()
					.Property(e => e.idO)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCLKL>()
					.Property(e => e.idR)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCLKL>()
					.Property(e => e.st_obj)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCLKL>()
					.Property(e => e.G5IDL)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCLKL>()
					.Property(e => e.G5UD)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCLKL>()
					.Property(e => e.G5RADR)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCLKL>()
					.Property(e => e.G5RSKL)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCNIER>()
					.Property(e => e.typBaz)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCNIER>()
					.Property(e => e.idO)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCNIER>()
					.Property(e => e.idR)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCNIER>()
					.Property(e => e.st_obj)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCNIER>()
					.Property(e => e.G5OPIS)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCNIER>()
					.Property(e => e.G5RPTW)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCNIER>()
					.Property(e => e.G5ROBCN)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCNIER>()
					.HasMany(e => e.G5RCDZE)
					.WithOptional(e => e.G5RCNIER)
					.HasForeignKey(e => e.id_G5RCNIER);

			modelBuilder.Entity<G5RCNIER>()
					.HasMany(e => e.G5RCLKL)
					.WithOptional(e => e.G5RCNIER)
					.HasForeignKey(e => e.id_G5RCNIER);

			modelBuilder.Entity<G5RCOBC>()
					.Property(e => e.typBaz)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCOBC>()
					.Property(e => e.idO)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCOBC>()
					.Property(e => e.idR)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCOBC>()
					.Property(e => e.st_obj)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCOBC>()
					.Property(e => e.G5OPIS)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCOBC>()
					.Property(e => e.G5ROBCN)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCW>()
					.Property(e => e.typBaz)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCW>()
					.Property(e => e.idO)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCW>()
					.Property(e => e.idR)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCW>()
					.Property(e => e.st_obj)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCW>()
					.Property(e => e.G5IRCW)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCW>()
					.Property(e => e.G5NRPR)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCW>()
					.Property(e => e.G5RDOK)
					.IsUnicode(false);

			modelBuilder.Entity<G5RCW>()
					.HasMany(e => e.G5RCNIER)
					.WithOptional(e => e.G5RCW)
					.HasForeignKey(e => e.id_G5RCW);
		}
	}
}
