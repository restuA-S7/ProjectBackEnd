﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BackEnd.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("BACKEND.Models.PemberianLampung", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bank")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("Bentuk")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("Fase")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("JK")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("Jenjang")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("KIP")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("KKS")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("KPS")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("KabupatenKota")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("Kecamatan")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<int?>("Kelas")
                        .HasColumnType("integer");

                    b.Property<string>("KeteranganPencairan")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("KeteranganTahap")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("KeteranganTambahan")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("LayakPIP")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("NIK")
                        .HasColumnType("text");

                    b.Property<string>("NISN")
                        .HasColumnType("text");

                    b.Property<string>("NPSN")
                        .HasColumnType("text");

                    b.Property<string>("NamaAyah")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("NamaIbu")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("NamaPengusul")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("NamaPengusulUtama")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("NamaSekolah")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("NamaSiswa")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("Nominal")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("NomorSK")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("NomorSKNominasi")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("PDID")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("PKH")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("Provinsi")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("Rekening")
                        .HasColumnType("text");

                    b.Property<string>("Rombel")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<int?>("Semester")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<int?>("Tahap")
                        .HasColumnType("integer");

                    b.Property<string>("TahapNominasi")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("TanggalAktifasi")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("TanggalCair")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("TanggalLahir")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("TanggalMulaiPecairan")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("TanggalSK")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("TanggalSKNominasi")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("TempatLahir")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("TipeSK")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("VirtualAccount")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("VirtualAccountNominasi")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.HasKey("Id");

                    b.ToTable("penerimaanLampung", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
