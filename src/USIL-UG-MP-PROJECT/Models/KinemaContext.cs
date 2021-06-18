using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace USIL_UG_MP_PROJECT.Models
{
    public partial class KinemaContext : DbContext
    {
        public KinemaContext()
        {
        }

        public KinemaContext(DbContextOptions<KinemaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AsuntoCitum> AsuntoCita { get; set; }
        public virtual DbSet<BoletaCitum> BoletaCita { get; set; }
        public virtual DbSet<Citum> Cita { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<DiagnosticoCitum> DiagnosticoCita { get; set; }
        public virtual DbSet<Especialistum> Especialista { get; set; }
        public virtual DbSet<HistorialClinico> HistorialClinicos { get; set; }
        public virtual DbSet<MetodoPago> MetodoPagos { get; set; }
        public virtual DbSet<Ubicacion> Ubicacions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=PC-ANGEL\\SQLEXPRESS;Initial Catalog=bdkinema;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<AsuntoCitum>(entity =>
            {
                entity.HasKey(e => e.IdAsunto)
                    .HasName("pk_asunto_id");

                entity.ToTable("asunto_cita");

                entity.Property(e => e.IdAsunto)
                    .ValueGeneratedNever()
                    .HasColumnName("id_asunto");

                entity.Property(e => e.IdEspecialista).HasColumnName("id_especialista");

                entity.Property(e => e.Precio)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("precio");

                entity.HasOne(d => d.IdEspecialistaNavigation)
                    .WithMany(p => p.AsuntoCita)
                    .HasForeignKey(d => d.IdEspecialista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_asunto_especialista");
            });

            modelBuilder.Entity<BoletaCitum>(entity =>
            {
                entity.HasKey(e => e.IdBoleta)
                    .HasName("pk_boleta_id");

                entity.ToTable("boleta_cita");

                entity.Property(e => e.IdBoleta)
                    .ValueGeneratedNever()
                    .HasColumnName("id_boleta");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdCita).HasColumnName("id_cita");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.HasOne(d => d.IdCitaNavigation)
                    .WithMany(p => p.BoletaCita)
                    .HasForeignKey(d => d.IdCita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_boleta_cita");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.BoletaCita)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_boleta_cliente");
            });

            modelBuilder.Entity<Citum>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("pk_cita_id");

                entity.ToTable("cita");

                entity.HasIndex(e => e.Fecha, "un_cita_fecha")
                    .IsUnique();

                entity.Property(e => e.IdCita)
                    .ValueGeneratedNever()
                    .HasColumnName("id_cita");

                entity.Property(e => e.Fecha)
                    .HasColumnType("date")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdAsunto).HasColumnName("id_asunto");

                entity.Property(e => e.IdMetodo).HasColumnName("id_metodo");

                entity.Property(e => e.IdPaciente).HasColumnName("id_paciente");

                entity.HasOne(d => d.IdAsuntoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdAsunto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cita_asunto");

                entity.HasOne(d => d.IdMetodoNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdMetodo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cita_metodo");

                entity.HasOne(d => d.IdPacienteNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cita_paciente");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("pk_cliente_id");

                entity.ToTable("cliente");

                entity.HasIndex(e => e.Celular, "un_cliente_celular")
                    .IsUnique();

                entity.HasIndex(e => e.Dni, "un_cliente_dni")
                    .IsUnique();

                entity.HasIndex(e => e.Email, "un_cliente_email")
                    .IsUnique();

                entity.Property(e => e.IdCliente)
                    .ValueGeneratedNever()
                    .HasColumnName("id_cliente");

                entity.Property(e => e.Celular).HasColumnName("celular");

                entity.Property(e => e.Dni).HasColumnName("dni");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(24)
                    .HasColumnName("email")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DiagnosticoCitum>(entity =>
            {
                entity.HasKey(e => e.IdDiagnostico)
                    .HasName("pk_diagnostico_id");

                entity.ToTable("diagnostico_cita");

                entity.Property(e => e.IdDiagnostico)
                    .ValueGeneratedNever()
                    .HasColumnName("id_diagnostico");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.IdCita).HasColumnName("id_cita");

                entity.HasOne(d => d.IdCitaNavigation)
                    .WithMany(p => p.DiagnosticoCita)
                    .HasForeignKey(d => d.IdCita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_diagnostico_cita");
            });

            modelBuilder.Entity<Especialistum>(entity =>
            {
                entity.HasKey(e => e.IdEspecialista)
                    .HasName("pk_especialista_id");

                entity.ToTable("especialista");

                entity.Property(e => e.IdEspecialista)
                    .ValueGeneratedNever()
                    .HasColumnName("id_especialista");

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("apellidos");

                entity.Property(e => e.IdUbicacion).HasColumnName("id_ubicacion");

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("nombres");

                entity.HasOne(d => d.IdUbicacionNavigation)
                    .WithMany(p => p.Especialista)
                    .HasForeignKey(d => d.IdUbicacion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_especialista_ubicacion");
            });

            modelBuilder.Entity<HistorialClinico>(entity =>
            {
                entity.HasKey(e => e.IdHistorial)
                    .HasName("pk_historial_id");

                entity.ToTable("historial_clinico");

                entity.Property(e => e.IdHistorial)
                    .ValueGeneratedNever()
                    .HasColumnName("id_historial");

                entity.Property(e => e.FechaCreacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_creacion");

                entity.Property(e => e.IdDiagnostico).HasColumnName("id_diagnostico");

                entity.HasOne(d => d.IdDiagnosticoNavigation)
                    .WithMany(p => p.HistorialClinicos)
                    .HasForeignKey(d => d.IdDiagnostico)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_historial_diagnostico");
            });

            modelBuilder.Entity<MetodoPago>(entity =>
            {
                entity.HasKey(e => e.IdMetodo)
                    .HasName("pk_metodo_id");

                entity.ToTable("metodo_pago");

                entity.Property(e => e.IdMetodo)
                    .ValueGeneratedNever()
                    .HasColumnName("id_metodo");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Empresa)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("empresa");
            });

            modelBuilder.Entity<Ubicacion>(entity =>
            {
                entity.HasKey(e => e.IdUbicacion)
                    .HasName("pk_ubicacion_id");

                entity.ToTable("ubicacion");

                entity.Property(e => e.IdUbicacion)
                    .ValueGeneratedNever()
                    .HasColumnName("id_ubicacion");

                entity.Property(e => e.Ciudad)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("ciudad");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(48)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Region)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("region");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
