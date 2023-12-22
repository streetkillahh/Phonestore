using Phonestore.Domain.Response;
using Phonestore.Domain.ViewModels.Profile;

namespace Phonestore.Service.Interfaces
{
    public interface IProfileService 
    {
        Task<BaseResponse<ProfileViewModel>> GetProfile(string userName);
        Task<BaseResponse<ProfileViewModel>> Save(ProfileViewModel model);
    }
}
