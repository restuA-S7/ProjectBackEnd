using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BACKEND.Models
{
    [Table("PemberianLampung")]
    public class PemberianLampung
    {
         [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string? PDID { get; set; }
        public string? NamaSiswa { get; set; }
        public string? NamaSekolah { get; set; }
        public string? Provinsi { get; set; }
        public string? KabupatenKota { get; set; }
        public string? Kecamatan { get; set; }

        public string? NIK { get; set; }
        public string? NISN { get; set; }
        public string? NPSN { get; set; }

        public int? Kelas { get; set; }
        public string? Rombel { get; set; }
        public int? Semester { get; set; }
        public string? Jenjang { get; set; }
        public string? Bentuk { get; set; }
        public string? JK { get; set; }
        public string? TempatLahir { get; set; }
        public string? TanggalLahir { get; set; }

        public string? NamaAyah { get; set; }
        public string? NamaIbu { get; set; }
        public string? Nominal { get; set; }
        public string? TipeSK { get; set; }
        public string? NomorSK { get; set; }
        public string? NomorSKNominasi { get; set; }
        public string? TanggalSK { get; set; }
        public string? TanggalSKNominasi { get; set; }

        public int? Tahap { get; set; }
        public string? TahapNominasi { get; set; }
        public string? VirtualAccount { get; set; }
        public string? VirtualAccountNominasi { get; set; }

        public string? Rekening { get; set; }
        public string? Bank { get; set; }
        public string? TanggalAktifasi { get; set; }
        public string? TanggalMulaiPecairan { get; set; }
        public string? TanggalCair { get; set; }

        public string? KIP { get; set; }
        public string? KKS { get; set; }
        public string? KPS { get; set; }
        public string? PKH { get; set; }
        public string? LayakPIP { get; set; }

        public string? NamaPengusul { get; set; }
        public string? NamaPengusulUtama { get; set; }
        public string? Fase { get; set; }
        public string? KeteranganTahap { get; set; }
        public string? KeteranganPencairan { get; set; }
        public string? KeteranganTambahan { get; set; }
        public string? Status { get; set; }
    }
}