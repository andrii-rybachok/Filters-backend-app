using Data.DataBase.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.DataBase
{
	public class ApplicationDbContext : DbContext
	{

		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{ }
		public DbSet<JobProject> JobProjects { get; set; }
		public DbSet<ProdProcess> ProdProcesses { get; set; }
		public DbSet<WorkPlace> WorkPlaces { get; set; }
		public DbSet<WorkPlaceCapacity> WorkPlaceCapacities { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<JobProject>()
				.Property(e => e.Numer)
				.IsUnicode(false);

			modelBuilder.Entity<JobProject>()
				.Property(e => e.Nazwa)
				.IsUnicode(false);

			modelBuilder.Entity<JobProject>()
				.Property(e => e.Opis)
				.IsUnicode(false);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.ModificationUser)
				.IsUnicode(false);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.ProcessDuration)
				.HasPrecision(10, 2);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.PartName)
				.IsUnicode(false);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.ProcessStatus)
				.IsUnicode(false);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.Note)
				.IsUnicode(false);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.ProdType)
				.IsUnicode(false);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.ProcessDurationPoduction)
				.HasPrecision(10, 2);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.ProcessDurationMakeReady)
				.HasPrecision(10, 2);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.CalcProcessPath)
				.IsUnicode(false);

			modelBuilder.Entity<ProdProcess>()
				.Property(e => e.Maszyna)
				.IsUnicode(false);

			modelBuilder.Entity<WorkPlace>()
				.Property(e => e.Code)
				.IsUnicode(false);

			modelBuilder.Entity<WorkPlace>()
				.Property(e => e.Name)
				.IsUnicode(false);

			modelBuilder.Entity<WorkPlace>()
				.Property(e => e.Note)
				.IsUnicode(false);


			modelBuilder.Entity<WorkPlaceCapacity>()
				.Property(e => e.Maszyna)
				.IsUnicode(false);
			modelBuilder.Entity<WorkPlace>()
				.HasMany(e => e.ProdProcesses)
				.WithOne(e => e.WorkPlace)
				.HasForeignKey(e => e.WorkplaceId);
		}
	}
}