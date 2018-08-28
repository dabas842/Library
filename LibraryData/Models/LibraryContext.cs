using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryData.Models
{
    public partial class LibraryContext : DbContext
    {
        public LibraryContext()
        {
        }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BranchHours> BranchHours { get; set; }
        public virtual DbSet<Checkout> Checkouts { get; set; }
        public virtual DbSet<CheckoutHistory> CheckoutHistories { get; set; }
        public virtual DbSet<Hold> Holds { get; set; }
        public virtual DbSet<LibraryAsset> LibraryAssets { get; set; }
        public virtual DbSet<LibraryBranch> LibraryBranches { get; set; }
        public virtual DbSet<LibraryCard> LibraryCards { get; set; }
        public virtual DbSet<Patron> Patrons { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Video> Videos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=Library;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>(entity =>
            {
                entity.Property(e => e.Author)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeweyIndex)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ISBN)
                    .IsRequired()
                    .HasColumnName("ISBN")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Checkout>(entity =>
            {
                entity.Property(e => e.Since).HasColumnType("datetime");

                entity.Property(e => e.Until).HasColumnType("datetime");
            });

            modelBuilder.Entity<CheckoutHistory>(entity =>
            {
                entity.Property(e => e.CheckedIn).HasColumnType("datetime");

                entity.Property(e => e.CheckedOut).HasColumnType("datetime");
            });

            modelBuilder.Entity<Hold>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.HoldPlaced).HasColumnType("datetime");
            });

            modelBuilder.Entity<LibraryAsset>(entity =>
            {
                entity.Property(e => e.Cost).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Title).IsRequired();
            });

            modelBuilder.Entity<LibraryBranch>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.OpenDate).HasColumnType("datetime");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LibraryCard>(entity =>
            {
                entity.Property(e => e.Created).HasColumnType("datetime");

                entity.Property(e => e.Fees).HasColumnType("decimal(8, 2)");
            });

            modelBuilder.Entity<Patron>(entity =>
            {
                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.TelephoneNumber).HasMaxLength(50);
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
