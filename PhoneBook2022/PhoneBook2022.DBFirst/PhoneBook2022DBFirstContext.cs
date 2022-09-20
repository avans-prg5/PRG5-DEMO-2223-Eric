using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PhoneBook2022.DBFirst
{
    public partial class PhoneBook2022DBFirstContext : DbContext
    {
        public PhoneBook2022DBFirstContext()
        {
        }

        public PhoneBook2022DBFirstContext(DbContextOptions<PhoneBook2022DBFirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; } = null!;
        public virtual DbSet<AddressType> AddressTypes { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=PhoneBook2022DBFirst;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.AdresType });

                entity.ToTable("Address");

                entity.Property(e => e.AdresType)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Extension).HasMaxLength(50);

                entity.Property(e => e.Number).HasMaxLength(6);

                entity.Property(e => e.PostalCode).HasMaxLength(10);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.Street).HasMaxLength(100);

                entity.HasOne(d => d.AdresTypeNavigation)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.AdresType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Address");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Address_Person");
            });

            modelBuilder.Entity<AddressType>(entity =>
            {
                entity.HasKey(e => e.Type);

                entity.ToTable("AddressType");

                entity.Property(e => e.Type)
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Person");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.TelephoneNumber).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
