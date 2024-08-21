using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projprog.Repositories.Models;

namespace projprog.Repositories
{
	internal class DatabaseContext : DbContext
	{
		const string DATABASE_URL = "Server=localhost;Port=3306;Database=projectdb;User=root;Password=abcd;";
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseMySql(DATABASE_URL, MySqlServerVersion.AutoDetect(DATABASE_URL));
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Invperson>().HasKey(e => new { e.Serial, e.Serpers });
			modelBuilder.Entity<ImageFP>().HasKey(e => new { e.Serial, e.Serpers });
			modelBuilder.Entity<ImageFace>().HasKey(e => new { e.Serial, e.Serpers });

			base.OnModelCreating(modelBuilder);
		}

		public DbSet<Invest> Invests { get; set; }
		public DbSet<Invperson> Invpersons { get; set; }
		public DbSet<Worldkey> Worldkeys { get; set; }
		public DbSet<Village> Villages { get; set; }
		public DbSet<Nation> Nations { get; set; }
		public DbSet<Attr> Attrs { get; set; }
		public DbSet<ImageFP> ImageFPs { get; set; }
		public DbSet<ImageFace> ImageFaces { get; set; }
		public DbSet<Vehicle> Vehicles {  get; set; }
	}
}
