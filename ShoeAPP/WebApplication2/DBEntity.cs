using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2
{
    public partial class DBEntity : DbContext
    {
        public DBEntity()
            : base("name=DBEntity")
        {
        }

        public virtual DbSet<brand> brands { get; set; }
        public virtual DbSet<cart> carts { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<payment> payments { get; set; }
        public virtual DbSet<shoe> shoes { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<brand>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<brand>()
                .HasMany(e => e.shoes)
                .WithRequired(e => e.brand)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cart>()
                .HasOptional(e => e.payment)
                .WithRequired(e => e.cart);

            modelBuilder.Entity<customer>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.shoes)
                .WithRequired(e => e.customer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<customer>()
                .HasMany(e => e.employees)
                .WithMany(e => e.customers)
                .Map(m => m.ToTable("guest").MapLeftKey("customer_id").MapRightKey("employee_id"));

            modelBuilder.Entity<employee>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<employee>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<payment>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<shoe>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<shoe>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<shoe>()
                .HasMany(e => e.carts)
                .WithRequired(e => e.shoe)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .Property(e => e.address)
                .IsUnicode(false);

            modelBuilder.Entity<supplier>()
                .HasMany(e => e.shoes)
                .WithRequired(e => e.supplier)
                .WillCascadeOnDelete(false);
        }
    }
}
