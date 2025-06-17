using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class TabelPemberianLampung : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "penerimaanLampung",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PDID = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    NamaSiswa = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    NamaSekolah = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Provinsi = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    KabupatenKota = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Kecamatan = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    NIK = table.Column<int>(type: "integer", nullable: false),
                    NISN = table.Column<int>(type: "integer", nullable: false),
                    NPSN = table.Column<int>(type: "integer", nullable: true),
                    Kelas = table.Column<int>(type: "integer", nullable: true),
                    Rombel = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Semester = table.Column<int>(type: "integer", nullable: true),
                    Jenjang = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Bentuk = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    JK = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    TempatLahir = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    TanggalLahir = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    NamaAyah = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    NamaIbu = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Nominal = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    TipeSK = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    NomorSK = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    NomorSKNominasi = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    TanggalSK = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    TanggalSKNominasi = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Tahap = table.Column<int>(type: "integer", nullable: true),
                    TahapNominasi = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    VirtualAccount = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    VirtualAccountNominasi = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Rekening = table.Column<int>(type: "integer", nullable: true),
                    Bank = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    TanggalAktifasi = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    TanggalMulaiPecairan = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    TanggalCair = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    KIP = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    KKS = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    KPS = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    PKH = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    LayakPIP = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    NamaPengusul = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    NamaPengusulUtama = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Fase = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    KeteranganTahap = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    KeteranganPencairan = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    KeteranganTambahan = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true),
                    Status = table.Column<string>(type: "character varying(512)", maxLength: 512, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_penerimaanLampung", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "penerimaanLampung");
        }
    }
}
