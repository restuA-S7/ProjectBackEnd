

using BACKEND.LaporanPemberian.CustomModels;
using BACKEND.LaporanPemberian.Inputs;
using BACKEND.LaporanPemberian.Services.Contracts;

namespace BACKEND.LaporanPemberian.Queries
{
    public class PemberianLampungQueries
    {
        [GraphQLName("getPemberianLampung")]
        public ModelPemberian GetPemberianLampung(
            [Service] IGetPemberianLampung service,
            ModelPemberianInput input,
            CancellationToken cancellationToken)
        {
            return service.GetPemberianLampung(input, cancellationToken);
        }
    }
}