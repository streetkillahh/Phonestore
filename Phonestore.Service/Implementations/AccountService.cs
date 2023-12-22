using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Phonestore.DAL.Interfaces;
using Phonestore.Domain.Entity;
using Phonestore.Domain.Entity.User;
using Phonestore.Domain.Enum;
using Phonestore.Domain.Helpers;
using Phonestore.Domain.Response;
using Phonestore.Domain.ViewModels.Account;
using Phonestore.Service.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;
using System.Security.Claims;

namespace Phonestore.Service.Implementations
{
    public class AccountService : IAccountService
    {
        private readonly IBaseRepository<User> _userRepository;
        private readonly IBaseRepository<Profile> _profileRepository;
        public AccountService(IBaseRepository<User> userRepository, 
            IBaseRepository<Profile> profileRepository)
        {
            _profileRepository = profileRepository;
            _userRepository = userRepository;
        }
        public async Task<BaseResponse<ClaimsIdentity>> Login(LoginViewModel model)
        {
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Name == model.Name);
                if (user == null)
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Пользователь не найден"
                    };
                }
                if (user.Password != HashPasswordHelper.HashPassword(model.Password))
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Неверный пароль или логин"
                    };
                }
                var result = Authenticate(user);
                return new BaseResponse<ClaimsIdentity>()
                {
                    Data = result,
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<ClaimsIdentity>();
            }
        }

        public async Task<BaseResponse<ClaimsIdentity>> Register(RegisterViewModel model)
        {
            try
            {
                var user = await _userRepository.GetAll().FirstOrDefaultAsync(x => x.Name == model.Name);
                if (user != null)
                {
                    return new BaseResponse<ClaimsIdentity>()
                    {
                        Description = "Пользователь с таким именем уже существует",
                    };
                }
                var profile = new Profile()
                {
                    Address = string.Empty,
                    Age = 0,
                    UserName = string.Empty
                };
                await _profileRepository.Create(profile);

               
                user = new User()
                {
                    Name = model.Name,
                    ProfileId = profile.Id,
                    Role = Role.User,
                    Password = HashPasswordHelper.HashPassword(model.Password)
                };
                await _userRepository.Create(user);
                var result = Authenticate(user);
                return new BaseResponse<ClaimsIdentity>()
                {
                    Data = result,
                    Description = "Пользователь добавлен",
                    StatusCode = StatusCode.OK
                };
            }
            catch (Exception ex)
            {
                return new BaseResponse<ClaimsIdentity>()
                {
                    Description = ex.Message,
                    StatusCode = StatusCode.InternalServerError
                };
            }
        }
        public ClaimsIdentity Authenticate (User user)
        {
            var claims = new List<Claim>()
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Name),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role.ToString())
            };

            return new ClaimsIdentity(claims, "ApplicationCookie",
                ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
        }
    }
}
