using Phonestore.Domain.Response;
using Phonestore.Domain.ViewModels.Account;
using System.Security.Claims;


namespace Phonestore.Service.Interfaces
{
    public interface IAccountService
    {
        Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model);
        Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model);

    }
}
