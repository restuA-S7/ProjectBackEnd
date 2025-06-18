using BACKEND.LaporanPemberian.CustomModels;
using BACKEND.LaporanPemberian.Inputs;

namespace BACKEND.LaporanPemberian.Services.Contracts
{
    public interface IGetPemberianLampung
    {
        //public List<ModelPemberian> GetPemberianLampung(ModelPemberianInput input, CancellationToken cancellationToken);
        public ModelPemberian GetPemberianLampung(ModelPemberianInput input, CancellationToken cancellationToken);
    }
}