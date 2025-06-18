using Microsoft.EntityFrameworkCore;
using BACKEND.Models.PemberianLampung;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }
    public DbSet<PemberianLampung> PemberianLampungs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PemberianLampung>(entity =>
        {
            entity.ToTable("penerimaanLampung");

            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.Property(e => e.PDID).HasMaxLength(512);
            entity.Property(e => e.NamaSiswa).HasMaxLength(512);
            entity.Property(e => e.NamaSekolah).HasMaxLength(512);
            entity.Property(e => e.Provinsi).HasMaxLength(512);
            entity.Property(e => e.KabupatenKota).HasMaxLength(512);
            entity.Property(e => e.Kecamatan).HasMaxLength(512);
            entity.Property(e => e.Rombel).HasMaxLength(512);
            entity.Property(e => e.Jenjang).HasMaxLength(512);
            entity.Property(e => e.Bentuk).HasMaxLength(512);
            entity.Property(e => e.JK).HasMaxLength(512);
            entity.Property(e => e.TempatLahir).HasMaxLength(512);
            entity.Property(e => e.TanggalLahir).HasMaxLength(512);
            entity.Property(e => e.NamaAyah).HasMaxLength(512);
            entity.Property(e => e.NamaIbu).HasMaxLength(512);
            entity.Property(e => e.Nominal).HasMaxLength(512);
            entity.Property(e => e.TipeSK).HasMaxLength(512);
            entity.Property(e => e.NomorSK).HasMaxLength(512);
            entity.Property(e => e.NomorSKNominasi).HasMaxLength(512);
            entity.Property(e => e.TanggalSK).HasMaxLength(512);
            entity.Property(e => e.TanggalSKNominasi).HasMaxLength(512);
            entity.Property(e => e.TahapNominasi).HasMaxLength(512);
            entity.Property(e => e.VirtualAccount).HasMaxLength(512);
            entity.Property(e => e.VirtualAccountNominasi).HasMaxLength(512);
            entity.Property(e => e.Bank).HasMaxLength(512);
            entity.Property(e => e.TanggalAktifasi).HasMaxLength(512);
            entity.Property(e => e.TanggalMulaiPecairan).HasMaxLength(512);
            entity.Property(e => e.TanggalCair).HasMaxLength(512);
            entity.Property(e => e.KIP).HasMaxLength(512);
            entity.Property(e => e.KKS).HasMaxLength(512);
            entity.Property(e => e.KPS).HasMaxLength(512);
            entity.Property(e => e.PKH).HasMaxLength(512);
            entity.Property(e => e.LayakPIP).HasMaxLength(512);
            entity.Property(e => e.NamaPengusul).HasMaxLength(512);
            entity.Property(e => e.NamaPengusulUtama).HasMaxLength(512);
            entity.Property(e => e.Fase).HasMaxLength(512);
            entity.Property(e => e.KeteranganTahap).HasMaxLength(512);
            entity.Property(e => e.KeteranganPencairan).HasMaxLength(512);
            entity.Property(e => e.KeteranganTambahan).HasMaxLength(512);
            entity.Property(e => e.Status).HasMaxLength(512);
        });
    }
}

