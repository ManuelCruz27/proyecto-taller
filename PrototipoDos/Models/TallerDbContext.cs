using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PrototipoDos.Models;

// Definición del contexto de la base de datos
public partial class TallerDbContext : DbContext
{
    // Constructor
    public TallerDbContext()
    {
    }

    // Constructor que recibe opciones de configuración del contexto
    public TallerDbContext(DbContextOptions<TallerDbContext> options)
        : base(options)
    {
    }

    // Propiedades virtuales para las entidades del modelo
    public virtual DbSet<Administradore> Administradores { get; set; }

    public virtual DbSet<GestionPersonalEmpleado> GestionPersonalEmpleado { get; set; }

    public virtual DbSet<GestionPersonalEmpleadoDireccion> GestionPersonalEmpleadoDireccions { get; set; }

    public virtual DbSet<InvMetale> InvMetales { get; set; }

    public virtual DbSet<InvPedidosBroquelero> InvPedidosBroqueleros { get; set; }

    public virtual DbSet<InvProducto> InvProductos { get; set; }

    public virtual DbSet<PedidosBroquelerosEntrada> PedidosBroquelerosEntradas { get; set; }

    public virtual DbSet<PedidosBroquelerosSalidum> PedidosBroquelerosSalida { get; set; }

    // Configuración de la conexión a la base de datos
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // Se sugiere evitar la inclusión de información sensible en el código
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        //Para proteger información potencialmente confidencial en su cadena de conexión, debe sacarla del código fuente. Puede evitar la estructuración de la cadena de conexión utilizando la sintaxis Nombre= para leerla desde la configuración; consulte https://go.microsoft.com/fwlink/?linkid=2131148. Para obtener más orientación sobre cómo almacenar cadenas de conexión, consulte https://go.microsoft.com/fwlink/?LinkId=723263.
        
        // Se sugiere evitar la inclusión de información sensible en el código
        => optionsBuilder.UseSqlServer("Server=Manuel;Database=Taller_DB;Trusted_Connection=True;TrustServerCertificate=True;");

    // Configuración del modelo de datos y relaciones entre entidades
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Administradore>(entity =>
        {
            entity.HasKey(e => e.AdminId).HasName("PK__Administ__719FE4E859C562FD");

            entity.Property(e => e.AdminId).HasColumnName("AdminID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Usuario)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Empleado).WithMany(p => p.Administradores)
                .HasForeignKey(d => d.EmpleadoId)
                .HasConstraintName("FK__Administr__Emple__4CA06362");
        });

        modelBuilder.Entity<GestionPersonalEmpleado>(entity =>
        {
            entity.HasKey(e => e.EmpleadoId).HasName("PK__GestionP__958BE6F01F1FF86E");

            entity.ToTable("GestionPersonal_Empleado");

            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.ApellidoMaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ApellidoPaterno)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CorreoEletronico)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NumeroCelular)
                .HasMaxLength(80)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<GestionPersonalEmpleadoDireccion>(entity =>
        {
            entity.HasKey(e => e.DireccionId).HasName("PK__GestionP__68906D44FA02B0D5");

            entity.ToTable("GestionPersonal_EmpleadoDireccion");

            entity.Property(e => e.DireccionId).HasColumnName("DireccionID");
            entity.Property(e => e.Calle).IsUnicode(false);
            entity.Property(e => e.Ciudad).IsUnicode(false);
            entity.Property(e => e.CodigoPostal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Colonia).IsUnicode(false);
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Estado).IsUnicode(false);
            entity.Property(e => e.Municipio).IsUnicode(false);
            entity.Property(e => e.NoExterior)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NoInterior)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");

            entity.HasOne(d => d.Empleado).WithMany(p => p.GestionPersonalEmpleadoDireccions)
                .HasForeignKey(d => d.EmpleadoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__GestionPe__Emple__403A8C7D");
        });

        modelBuilder.Entity<InvMetale>(entity =>
        {
            entity.HasKey(e => e.MetalId).HasName("PK__InvMetal__ACC86E9B55841CF1");

            entity.Property(e => e.MetalId).HasColumnName("MetalID");
            entity.Property(e => e.Gramos).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Kilataje)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreMetal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<InvPedidosBroquelero>(entity =>
        {
            entity.HasKey(e => e.PedidoId).HasName("PK__InvPedid__09BA1410A193F82E");

            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
        });

        modelBuilder.Entity<InvProducto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__InvProdu__A430AE8375FBC0AB");

            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.Existencias).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.ModeloONumero)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Modelo_O_Numero");
            entity.Property(e => e.NombreCompletoProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreProducto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioPorPar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StatusProductoId).HasColumnName("StatusProductoID");
            entity.Property(e => e.TipoMetal)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CodigoRelacionado)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CodigoRelacionado");
            entity.Property(e => e.Kilataje)
                  .HasMaxLength(50)
                  .IsUnicode(false)
                  .HasColumnName("Kilataje");
            entity.Property(e => e.MetalID).HasColumnName("MetalID");

        });

        modelBuilder.Entity<PedidosBroquelerosEntrada>(entity =>
        {
            entity.HasKey(e => e.PedidoEntradaId).HasName("PK__PedidosB__3EE13C68AFD13A85");

            entity.Property(e => e.PedidoEntradaId).HasColumnName("PedidoEntradaID");
            entity.Property(e => e.Empleado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.Kilate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KilateId).HasColumnName("KilateID");
            entity.Property(e => e.Malo).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MermaG)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Merma_G");
            entity.Property(e => e.ParesBroqueles).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.PedidoDetalleId).HasColumnName("PedidoDetalleID");
            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.Peso).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.TotalPagar)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Total_Pagar");
            entity.Property(e => e.Tuerca).HasColumnType("decimal(18, 3)");

            entity.HasOne(d => d.PedidoDetalle).WithMany(p => p.PedidosBroquelerosEntrada)
                .HasForeignKey(d => d.PedidoDetalleId)
                .HasConstraintName("FK__PedidosBr__Pedid__0C85DE4D");

            entity.HasOne(d => d.Pedido).WithMany(p => p.PedidosBroquelerosEntrada)
                .HasForeignKey(d => d.PedidoId)
                .HasConstraintName("FK__PedidosBr__Total__0B91BA14");
        });

        modelBuilder.Entity<PedidosBroquelerosSalidum>(entity =>
        {
            entity.HasKey(e => e.PedidoDetalleId).HasName("PK__PedidosB__12156C630434CFE3");

            entity.Property(e => e.PedidoDetalleId).HasColumnName("PedidoDetalleID");
            entity.Property(e => e.CientoCasquilla)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Ciento_Casquilla");
            entity.Property(e => e.CientoPernos)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Ciento_Pernos");
            entity.Property(e => e.CientoTuerca)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Ciento_Tuerca");
            entity.Property(e => e.Empleado)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EmpleadoId).HasColumnName("EmpleadoID");
            entity.Property(e => e.FechaSalida)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Salida");
            entity.Property(e => e.GramosCasquilla)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Gramos_Casquilla");
            entity.Property(e => e.GramosPernos)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Gramos_Pernos");
            entity.Property(e => e.GramosSoldadura)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Gramos_Soldadura");
            entity.Property(e => e.GramosTotal)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Gramos_Total");
            entity.Property(e => e.GramosTuerca)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Gramos_Tuerca");
            entity.Property(e => e.Kilate)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KilateId).HasColumnName("KilateID");
            entity.Property(e => e.ParesCasquilla)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Pares_Casquilla");
            entity.Property(e => e.ParesEstimados)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Pares_Estimados");
            entity.Property(e => e.ParesPernos)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Pares_Pernos");
            entity.Property(e => e.ParesTuerca)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Pares_Tuerca");
            entity.Property(e => e.PedidoId).HasColumnName("PedidoID");
            entity.Property(e => e.Producto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProductoId).HasColumnName("ProductoID");
            entity.Property(e => e.StatusPedidoDetalleId).HasColumnName("StatusPedidoDetalleID");

            entity.HasOne(d => d.Pedido).WithMany(p => p.PedidosBroquelerosSalida)
                .HasForeignKey(d => d.PedidoId)
                .HasConstraintName("FK__PedidosBr__Fecha__08B54D69");
        });

        // Llamada al método de configuración parcial
        OnModelCreatingPartial(modelBuilder);
    }
    // Método parcial para completar la configuración del modelo
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
