using Data.DTOs;
using Data.Entities;
using Data.Models;
using Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IAccountsService
    {
        Task Register(RegisterModel model);
        Task Login(LoginModel model);
        Task<ReturnRole> GetRole(LoginModel model);
        Task<User> GetUser(LoginModel model);

        //Task<LoginResponseDto> Login(LoginModel model);
        //Task Logout(string refreshToken);
        Task Logout();
        //Task<UserTokens> RefreshTokens(UserTokens tokens);

        //Task RemoveExpiredRefreshTokens();

        //Task<ResetToken> GenerageResetToken(string email);
        //Task ResetPassword(ResetPasswordModel model);
    }

    // TODO: create endpoints for resetting user password 
/*    public class ResetToken
    {
        public string Token { get; set; }
    }
    public class ResetPasswordModel
    {
        public string NewPassword { get; set; }
        public string Token { get; set; }
    }*/
}
