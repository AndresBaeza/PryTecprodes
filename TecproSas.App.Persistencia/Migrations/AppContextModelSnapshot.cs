﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TecproSas.App.Persistencia;

namespace TecproSas.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TecproSas.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("clienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidos")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("direccionCliente")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("email")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("nacionalidad")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("nit")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("nombre")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("telefono")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("clienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("TecproSas.App.Dominio.Fase", b =>
                {
                    b.Property<int>("faseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("actualizacionVisita")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("fechaInicioFase")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaVisitas")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombreFase")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("visitas")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("faseId");

                    b.ToTable("Fases");
                });

            modelBuilder.Entity("TecproSas.App.Dominio.Login", b =>
                {
                    b.Property<int>("loginId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("clienteId")
                        .HasColumnType("int");

                    b.Property<string>("direccionIp")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<DateTime>("fechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("usuarioId")
                        .HasColumnType("int");

                    b.HasKey("loginId");

                    b.HasIndex("clienteId");

                    b.HasIndex("usuarioId");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("TecproSas.App.Dominio.Proyecto", b =>
                {
                    b.Property<int>("proyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("aprobadoPor")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int?>("clienteId")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("faseActual")
                        .HasColumnType("int");

                    b.Property<int?>("faseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("presupuesto")
                        .HasColumnType("int");

                    b.Property<int?>("servicioId")
                        .HasColumnType("int");

                    b.Property<DateTime>("tiempoEjecucion")
                        .HasColumnType("datetime2");

                    b.Property<int?>("usuarioId")
                        .HasColumnType("int");

                    b.HasKey("proyectoId");

                    b.HasIndex("clienteId");

                    b.HasIndex("faseId");

                    b.HasIndex("servicioId");

                    b.HasIndex("usuarioId");

                    b.ToTable("Proyectos");
                });

            modelBuilder.Entity("TecproSas.App.Dominio.Servicio", b =>
                {
                    b.Property<int>("servicioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("fechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombServicio")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("valor")
                        .HasColumnType("int");

                    b.HasKey("servicioId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("TecproSas.App.Dominio.Usuario", b =>
                {
                    b.Property<int>("usuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellidos")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("contrasenia")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("direccion")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("estado")
                        .HasColumnType("int");

                    b.Property<string>("nicknname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("nombre")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<int>("rol")
                        .HasColumnType("int");

                    b.HasKey("usuarioId");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("TecproSas.App.Dominio.Login", b =>
                {
                    b.HasOne("TecproSas.App.Dominio.Cliente", "cliente")
                        .WithMany()
                        .HasForeignKey("clienteId");

                    b.HasOne("TecproSas.App.Dominio.Usuario", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioId");

                    b.Navigation("cliente");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("TecproSas.App.Dominio.Proyecto", b =>
                {
                    b.HasOne("TecproSas.App.Dominio.Cliente", "cliente")
                        .WithMany("proyecto")
                        .HasForeignKey("clienteId");

                    b.HasOne("TecproSas.App.Dominio.Fase", "fase")
                        .WithMany("proyecto")
                        .HasForeignKey("faseId");

                    b.HasOne("TecproSas.App.Dominio.Servicio", "servicio")
                        .WithMany()
                        .HasForeignKey("servicioId");

                    b.HasOne("TecproSas.App.Dominio.Usuario", null)
                        .WithMany("listProyec")
                        .HasForeignKey("usuarioId");

                    b.Navigation("cliente");

                    b.Navigation("fase");

                    b.Navigation("servicio");
                });

            modelBuilder.Entity("TecproSas.App.Dominio.Cliente", b =>
                {
                    b.Navigation("proyecto");
                });

            modelBuilder.Entity("TecproSas.App.Dominio.Fase", b =>
                {
                    b.Navigation("proyecto");
                });

            modelBuilder.Entity("TecproSas.App.Dominio.Usuario", b =>
                {
                    b.Navigation("listProyec");
                });
#pragma warning restore 612, 618
        }
    }
}
