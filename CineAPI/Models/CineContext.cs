using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CineAPI.Models;

public partial class CineContext : DbContext
{
    public CineContext(DbContextOptions<CineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Reservacion> Reservacions { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__3DD0A8CBE8B6261F");

            entity.ToTable("Cliente");

            entity.Property(e => e.IdCliente).HasColumnName("Id_Cliente");
            entity.Property(e => e.Apellido)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.IdUsuarioFk).HasColumnName("Id_Usuario_FK");
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);

            entity.HasOne(d => d.IdUsuarioFkNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdUsuarioFk)
                .HasConstraintName("FK__Cliente__Id_Usua__46E78A0C");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.CodEmpleado).HasName("PK__Empleado__18E393299203DF80");

            entity.Property(e => e.CodEmpleado).HasColumnName("Cod_Empleado");
            entity.Property(e => e.Apellido)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Reservacion>(entity =>
        {
            entity.HasKey(e => e.CodigoReserva).HasName("PK__Reservac__1D93C1C43DAF3162");

            entity.ToTable("Reservacion");

            entity.Property(e => e.CodigoReserva).HasColumnName("Codigo_Reserva");
            entity.Property(e => e.FechaReserva).HasColumnName("Fecha_Reserva");
            entity.Property(e => e.IdClienteFk).HasColumnName("Id_Cliente_FK");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Metodo_Pago");
            entity.Property(e => e.NumeroSilla)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Numero_silla");
            entity.Property(e => e.Pelicula)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.IdClienteFkNavigation).WithMany(p => p.Reservacions)
                .HasForeignKey(d => d.IdClienteFk)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Reservaci__Id_Cl__49C3F6B7");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuarios__63C76BE2B4581287");

            entity.Property(e => e.IdUsuario).HasColumnName("Id_Usuario");
            entity.Property(e => e.CodEmpleadoFkUsua).HasColumnName("Cod_Empleado_FK_Usua");
            entity.Property(e => e.Contra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.NombreUsu)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Nombre_Usu");
            entity.Property(e => e.RolSistema)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Rol_sistema");

            entity.HasOne(d => d.CodEmpleadoFkUsuaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.CodEmpleadoFkUsua)
                .HasConstraintName("FK__Usuarios__Cod_Em__3D5E1FD2");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
