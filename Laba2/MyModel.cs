namespace Laba2
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("name=MyModel")
        {
        }

        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Dimension> Dimensions { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Transport> Transports { get; set; }
        public virtual DbSet<Type> Types { get; set; }
        public virtual DbSet<Weight> Weights { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>()
                .HasMany(e => e.Transports)
                .WithRequired(e => e.Brand)
                .HasForeignKey(e => e.ID_Brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Dimension>()
                .HasMany(e => e.Transports)
                .WithRequired(e => e.Dimension)
                .HasForeignKey(e => e.ID_Dimension)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Driver>()
                .HasMany(e => e.Routes)
                .WithRequired(e => e.Driver)
                .HasForeignKey(e => e.ID_Driver)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Experience>()
                .HasMany(e => e.Drivers)
                .WithRequired(e => e.Experience)
                .HasForeignKey(e => e.ID_Experience)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Route>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Route>()
                .Property(e => e.Duration)
                .IsUnicode(false);

            modelBuilder.Entity<Route>()
                .Property(e => e.Disnatce)
                .IsUnicode(false);

            modelBuilder.Entity<Transport>()
                .HasMany(e => e.Drivers)
                .WithRequired(e => e.Transport)
                .HasForeignKey(e => e.ID_Transport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Type>()
                .HasMany(e => e.Transports)
                .WithRequired(e => e.Type)
                .HasForeignKey(e => e.ID_Type)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Weight>()
                .HasMany(e => e.Transports)
                .WithRequired(e => e.Weight)
                .HasForeignKey(e => e.ID_Weight)
                .WillCascadeOnDelete(false);
        }
    }
}
