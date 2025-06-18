using BACKEND.LaporanPemberian.CustomModels;
using BACKEND.LaporanPemberian.Inputs;
using BACKEND.LaporanPemberian.Services.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BACKEND.LaporanPemberian.Services
{
    public class PemberianLampungService : IGetPemberianLampung
    {
        private readonly AppDbContext _dbContext;
        public PemberianLampungService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //public List<ModelPemberian> GetPemberianLampung(ModelPemberianInput input, CancellationToken cancellationToken)
        public ModelPemberian GetPemberianLampung(ModelPemberianInput input, CancellationToken cancellationToken)
        {
            var result = _dbContext.PemberianLampungs.AsNoTracking()
                        .Where(p => p.NIK == input.NIK && p.NISN == input.NISN)
                        .Select(p => new ModelPemberian
                        {
                            Nama = p.NamaSiswa,
                            NamaSekolah = p.NamaSekolah,
                            NIK = p.NIK,
                            NISN = p.NISN,
                            Rombel = p.Rombel,
                            Nominal = p.Nominal,
                            TipeSK = p.TipeSK,
                            NomorSK = p.NomorSK,
                            Bank = p.Bank,
                            Rekening = p.Rekening
                        }).FirstOrDefault();//.ToList();
            if (result == null) throw new ArgumentException("Data Penerimaan Tidak DiTemukan");

            return result;
        }
    }
}