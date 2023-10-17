﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Salon.Migrations
{
    [DbContext(typeof(BeautyContext))]
    [Migration("20231003150421_V3")]
    partial class V3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("KorisnikNotifikacija", b =>
                {
                    b.Property<int>("KorisniciId")
                        .HasColumnType("int");

                    b.Property<int>("NotifikacijeID")
                        .HasColumnType("int");

                    b.HasKey("KorisniciId", "NotifikacijeID");

                    b.HasIndex("NotifikacijeID");

                    b.ToTable("KorisnikNotifikacija");
                });

            modelBuilder.Entity("KorisnikPogodnijiTermin", b =>
                {
                    b.Property<int>("KorisniciId")
                        .HasColumnType("int");

                    b.Property<int>("PogodnijiTerminiID")
                        .HasColumnType("int");

                    b.HasKey("KorisniciId", "PogodnijiTerminiID");

                    b.HasIndex("PogodnijiTerminiID");

                    b.ToTable("KorisnikPogodnijiTermin");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Models.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Models.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Ime")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.Property<string>("Prezime")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

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

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("AppUser");
                });

            modelBuilder.Entity("Models.Notifikacija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Datum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TerminID")
                        .HasColumnType("int");

                    b.Property<int>("Tip")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TerminID");

                    b.ToTable("Notifikacije");
                });

            modelBuilder.Entity("Models.Placanje", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RadnikId")
                        .HasColumnType("int");

                    b.Property<int?>("TipUslugeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RadnikId");

                    b.HasIndex("TipUslugeID");

                    b.ToTable("Placanja");
                });

            modelBuilder.Entity("Models.PogodnijiTermin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("TerminID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TerminID");

                    b.ToTable("PogodnijiTermini");
                });

            modelBuilder.Entity("Models.Preporuka", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Komentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("Ocena")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Preporuke");
                });

            modelBuilder.Entity("Models.Recenzija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Komentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int>("Ocena")
                        .HasColumnType("int");

                    b.Property<int?>("RadnikId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("RadnikId");

                    b.ToTable("Recenzije");
                });

            modelBuilder.Entity("Models.SalonInfo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VremeDo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VremeOd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SalonInfo");
                });

            modelBuilder.Entity("Models.Termin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int?>("RadnikId")
                        .HasColumnType("int");

                    b.Property<bool>("StatusOdradjen")
                        .HasColumnType("bit");

                    b.Property<int?>("UslugaID")
                        .HasColumnType("int");

                    b.Property<int?>("VremeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("RadnikId");

                    b.HasIndex("UslugaID");

                    b.HasIndex("VremeID");

                    b.ToTable("Termini");
                });

            modelBuilder.Entity("Models.TipUsluge", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Trajanje")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("TipoviUsluge");
                });

            modelBuilder.Entity("Models.Usluga", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Cena")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TipUslugeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("TipUslugeID");

                    b.ToTable("Usluge");
                });

            modelBuilder.Entity("Models.Vreme", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("TipUslugeID")
                        .HasColumnType("int");

                    b.Property<string>("VremeDo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VremeOd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TipUslugeID");

                    b.ToTable("Vremena");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.HasBaseType("Models.AppUser");

                    b.Property<double>("Popust")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Korisnik");
                });

            modelBuilder.Entity("Models.Radnik", b =>
                {
                    b.HasBaseType("Models.AppUser");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int?>("TipUslugeID")
                        .HasColumnType("int");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("TipUslugeID");

                    b.HasDiscriminator().HasValue("Radnik");
                });

            modelBuilder.Entity("KorisnikNotifikacija", b =>
                {
                    b.HasOne("Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("KorisniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Notifikacija", null)
                        .WithMany()
                        .HasForeignKey("NotifikacijeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("KorisnikPogodnijiTermin", b =>
                {
                    b.HasOne("Models.Korisnik", null)
                        .WithMany()
                        .HasForeignKey("KorisniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.PogodnijiTermin", null)
                        .WithMany()
                        .HasForeignKey("PogodnijiTerminiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Models.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Models.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Notifikacija", b =>
                {
                    b.HasOne("Models.Termin", "Termin")
                        .WithMany()
                        .HasForeignKey("TerminID");

                    b.Navigation("Termin");
                });

            modelBuilder.Entity("Models.Placanje", b =>
                {
                    b.HasOne("Models.Radnik", "Radnik")
                        .WithMany("Placanja")
                        .HasForeignKey("RadnikId");

                    b.HasOne("Models.TipUsluge", "TipUsluge")
                        .WithMany()
                        .HasForeignKey("TipUslugeID");

                    b.Navigation("Radnik");

                    b.Navigation("TipUsluge");
                });

            modelBuilder.Entity("Models.PogodnijiTermin", b =>
                {
                    b.HasOne("Models.Termin", "Termin")
                        .WithMany()
                        .HasForeignKey("TerminID");

                    b.Navigation("Termin");
                });

            modelBuilder.Entity("Models.Preporuka", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("Models.Recenzija", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany()
                        .HasForeignKey("KorisnikId");

                    b.HasOne("Models.Radnik", "Radnik")
                        .WithMany("Recenzije")
                        .HasForeignKey("RadnikId");

                    b.Navigation("Korisnik");

                    b.Navigation("Radnik");
                });

            modelBuilder.Entity("Models.Termin", b =>
                {
                    b.HasOne("Models.Korisnik", "Korisnik")
                        .WithMany("Termini")
                        .HasForeignKey("KorisnikId");

                    b.HasOne("Models.Radnik", "Radnik")
                        .WithMany("Termini")
                        .HasForeignKey("RadnikId");

                    b.HasOne("Models.Usluga", "Usluga")
                        .WithMany()
                        .HasForeignKey("UslugaID");

                    b.HasOne("Models.Vreme", "Vreme")
                        .WithMany()
                        .HasForeignKey("VremeID");

                    b.Navigation("Korisnik");

                    b.Navigation("Radnik");

                    b.Navigation("Usluga");

                    b.Navigation("Vreme");
                });

            modelBuilder.Entity("Models.Usluga", b =>
                {
                    b.HasOne("Models.TipUsluge", "TipUsluge")
                        .WithMany("Usluge")
                        .HasForeignKey("TipUslugeID");

                    b.Navigation("TipUsluge");
                });

            modelBuilder.Entity("Models.Vreme", b =>
                {
                    b.HasOne("Models.TipUsluge", "TipUsluge")
                        .WithMany()
                        .HasForeignKey("TipUslugeID");

                    b.Navigation("TipUsluge");
                });

            modelBuilder.Entity("Models.Radnik", b =>
                {
                    b.HasOne("Models.Korisnik", null)
                        .WithMany("Radnici")
                        .HasForeignKey("KorisnikId");

                    b.HasOne("Models.TipUsluge", "TipUsluge")
                        .WithMany("Radnici")
                        .HasForeignKey("TipUslugeID");

                    b.Navigation("TipUsluge");
                });

            modelBuilder.Entity("Models.TipUsluge", b =>
                {
                    b.Navigation("Radnici");

                    b.Navigation("Usluge");
                });

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Navigation("Radnici");

                    b.Navigation("Termini");
                });

            modelBuilder.Entity("Models.Radnik", b =>
                {
                    b.Navigation("Placanja");

                    b.Navigation("Recenzije");

                    b.Navigation("Termini");
                });
#pragma warning restore 612, 618
        }
    }
}
