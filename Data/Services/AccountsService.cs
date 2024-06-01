using AutoMapper;
using Data.DTOs;
using Data.Entities;
using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data.Services
{
    public class ReturnRole
    {
        public string role { get; set; }
        public int id { get; set; }

        public ReturnRole(string role, int id = 1)
        {
            this.role = role;
            this.id = id; 
        }
    }
    public class AccountsService : IAccountsService
    {
        private readonly UserManager<User> userManager;
        private readonly IMapper mapper;
        private readonly SignInManager<User> signInManager;

        public AccountsService(UserManager<User> userManager, IMapper mapper, SignInManager<User> signInManager)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.signInManager = signInManager;
        }
        public async Task Login(LoginModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null || !await userManager.CheckPasswordAsync(user, model.Password))
                throw new HttpException("Invalid user login or password.", HttpStatusCode.BadRequest);

            await signInManager.SignInAsync(user, true);
            

            //await signInManager.SignInAsync(user, true);

            // generate token
            /*return new LoginResponseDto
            {
                AccessToken = jwtService.CreateToken(jwtService.GetClaims(user)),
                RefreshToken = CreateRefreshToken(user.Id).Token
            };*/
            //throw new NotImplementedException();
        }

        public async Task<ReturnRole> GetRole(LoginModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null || !await userManager.CheckPasswordAsync(user, model.Password))
                throw new HttpException("Invalid user login or password.", HttpStatusCode.BadRequest);

            //await signInManager.SignInAsync(user, true);
            var Role = new ReturnRole(user.Role);
            return Role;

            //await signInManager.SignInAsync(user, true);

            // generate token
            /*return new LoginResponseDto
            {
                AccessToken = jwtService.CreateToken(jwtService.GetClaims(user)),
                RefreshToken = CreateRefreshToken(user.Id).Token
            };*/
            //throw new NotImplementedException();
        }

        public async Task<User> GetUser(LoginModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null || !await userManager.CheckPasswordAsync(user, model.Password))
                throw new HttpException("Invalid user login or password.", HttpStatusCode.BadRequest);

            //await signInManager.SignInAsync(user, true);
            return user;

        }

        public async Task Logout()
        {
            await signInManager.SignOutAsync();
            /*

            var refrestTokenEntity = await refreshTokenR.GetItemBySpec(new RefreshTokenSpecs.ByToken(refreshToken));

            if (refrestTokenEntity == null)
                throw new HttpException(Errors.InvalidToken, HttpStatusCode.BadRequest);

            refreshTokenR.Delete(refrestTokenEntity);
            refreshTokenR.Save();
            */
            //throw new NotImplementedException();
        }

        public async Task Register(RegisterModel model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user != null)
                throw new HttpException("Email is already exists.", HttpStatusCode.BadRequest);

            // create user
            //var newUser = mapper.Map<User>(model);
            var newUser = new User()
            {
                Email = model.Email,
                UserName = model.Email,
                PhoneNumber = model.PhoneNumber,
                Birthdate = model.Birthdate,
                Role = model.Role,
            };

            var result = await userManager.CreateAsync(newUser, model.Password);

            if (!result.Succeeded)
                throw new HttpException(string.Join(" ", result.Errors.Select(x => x.Description)), HttpStatusCode.BadRequest);
        }
    }
}
