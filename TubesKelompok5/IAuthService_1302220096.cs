using System.Threading.Tasks;

namespace TubesKelompok5
{
    public interface IAuthService_1302220096
    {
        Task<ServiceResponse_1302220096<string>> RegisterAsync(UserModel_1302220096 model);
        Task<ServiceResponse_1302220096<string>> LoginAsync(UserModel_1302220096 model);
    }
}
