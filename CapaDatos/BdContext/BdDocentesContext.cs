using System;
using System.Collections.Generic;
using CapaEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CapaDatos
{
    public partial class BdDocentesContext : DbContext
    {
        public BdDocentesContext()
        {
        }

        public BdDocentesContext(DbContextOptions<BdDocentesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Docente> Docentes { get; set; } = null!;
        public virtual DbSet<Grupo> Grupos { get; set; } = null!;
        public virtual DbSet<Modulo> Modulos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Docente>(entity =>
            {
                entity.HasKey(e => e.IdDocente)
                    .HasName("PK__Docentes__64A8726E3169C223");

                entity.Property(e => e.IdDocente).HasMaxLength(15);

                entity.Property(e => e.Apellidos).HasMaxLength(20);

                entity.Property(e => e.Celular).HasMaxLength(15);

                entity.Property(e => e.Correo).HasMaxLength(60);

                entity.Property(e => e.Direccion).HasMaxLength(20);

                entity.Property(e => e.Municipio).HasMaxLength(50);

                entity.Property(e => e.Nombres).HasMaxLength(20);
            });

            modelBuilder.Entity<Grupo>(entity =>
            {
                entity.HasKey(e => e.IdGrupos)
                    .HasName("PK__Grupos__3F43F8B0F1A4873E");

                entity.Property(e => e.IdGrupos).ValueGeneratedNever();

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.IdDocente1).HasMaxLength(15);

                entity.Property(e => e.Jornada).HasMaxLength(20);

                entity.HasOne(d => d.IdDocente1Navigation)
                    .WithMany(p => p.Grupos)
                    .HasForeignKey(d => d.IdDocente1)
                    .HasConstraintName("FK__Grupos__IdDocent__3B75D760");

                entity.HasOne(d => d.IdModulo1Navigation)
                    .WithMany(p => p.Grupos)
                    .HasForeignKey(d => d.IdModulo1)
                    .HasConstraintName("FK__Grupos__IdModulo__3A81B327");
            });

            modelBuilder.Entity<Modulo>(entity =>
            {
                entity.HasKey(e => e.IdModulo)
                    .HasName("PK__Modulos__D9F153150D9D34CE");

                entity.Property(e => e.IdModulo).ValueGeneratedNever();

                entity.Property(e => e.NombreModulo).HasMaxLength(50);

                entity.Property(e => e.Programa).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
