using Phonestore.Domain.Response;
using Phonestore.Domain.ViewModels.Account;
using Phonestore.Service.Interfaces;
using System.Security.Claims;

namespace Phonestore.Service.Implementations
{
    public class AccountService : IAccountService
    {
        public Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
