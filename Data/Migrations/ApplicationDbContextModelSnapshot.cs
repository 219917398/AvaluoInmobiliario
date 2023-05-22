﻿// <auto-generated />
using System;
using AvaluoInmobiliario.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AvaluoInmobiliario.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AvaluoInmobiliario.Models.Avaluo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AreasAccesorias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Calle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CallesLimOrientacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cerrajeria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cimentacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaseGeneralInmueble")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClasifZona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Closets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoPostal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colindancia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Colonia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comentarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComentariosEntorno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Configuracion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conjunto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConstruccionesPredom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DelegacionMunicipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DensidadHabitacional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("DensidadPoblacion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DeterminacionValor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dimensiones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EdadConstrucciones")
                        .HasColumnType("int");

                    b.Property<string>("ElementosAccesorios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EquipamientoUrbano")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Escaleras")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoConservacion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EstatusAvaluoId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaAvaluo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Giro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("IndiceSaturacion")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("InfraestructuraDisponible")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstalacionesElectricas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstalacionesEspeciales")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstalacionesHidraulicas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstalacionesSanitarias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IntensidadFlujoVehicular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LosasAzoteas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LosasEntrepisos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MueblesFijos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Muros")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Muros2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NivelSocioeconomico")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumExterior")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumInterior")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NumNiveles")
                        .HasColumnType("int");

                    b.Property<string>("ObrasComplementarias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtrosServicios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pisos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pisos2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plafones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropietarioInmueble")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PropositoAvaluo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Puertas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefProxUrbana")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Restricciones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiciosBasicos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Solicitante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SuperEstructura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("SuperficieVendible")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SuperficiesCubiertas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoPropiedad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Topografia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UbicacionLoteCalle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsoSuelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Valuador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ventanas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViasAcceso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VidaUtilRemanente")
                        .HasColumnType("int");

                    b.Property<string>("Vidrieria")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EstatusAvaluoId");

                    b.ToTable("Avaluos");
                });

            modelBuilder.Entity("AvaluoInmobiliario.Models.AvaluoArchivo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Archivo")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("AvaluoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreArchivo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoArchivo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AvaluoId");

                    b.ToTable("AvaluoArchivos");
                });

            modelBuilder.Entity("AvaluoInmobiliario.Models.AvaluoEstatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AvaluoEstatus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Descripcion = "Nuevo"
                        },
                        new
                        {
                            Id = 2,
                            Descripcion = "En proceso"
                        },
                        new
                        {
                            Id = 3,
                            Descripcion = "Completado"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AvaluoInmobiliario.Models.Avaluo", b =>
                {
                    b.HasOne("AvaluoInmobiliario.Models.AvaluoEstatus", "EstatusAvaluo")
                        .WithMany("Avaluos")
                        .HasForeignKey("EstatusAvaluoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EstatusAvaluo");
                });

            modelBuilder.Entity("AvaluoInmobiliario.Models.AvaluoArchivo", b =>
                {
                    b.HasOne("AvaluoInmobiliario.Models.Avaluo", "Avaluo")
                        .WithMany("AvaluoArchivos")
                        .HasForeignKey("AvaluoId");

                    b.Navigation("Avaluo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AvaluoInmobiliario.Models.Avaluo", b =>
                {
                    b.Navigation("AvaluoArchivos");
                });

            modelBuilder.Entity("AvaluoInmobiliario.Models.AvaluoEstatus", b =>
                {
                    b.Navigation("Avaluos");
                });
#pragma warning restore 612, 618
        }
    }
}
