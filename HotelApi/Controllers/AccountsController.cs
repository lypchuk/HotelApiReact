using Data.Interfaces;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountsService accountsService;

        public AccountsController(IAccountsService accountsService)
        {
            this.accountsService = accountsService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            await accountsService.Register(model);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            await accountsService.Login(model);
            //return Ok();
            return Ok();
        }

        [HttpPost("getrole")]
        public async Task<IActionResult> GetRole([FromBody] LoginModel model)
        {
            return Ok(await accountsService.GetRole(model));
        }

        [HttpPost("getUser")]
        public async Task<IActionResult> GetUser([FromBody] LoginModel model)
        {
            return Ok(await accountsService.GetUser(model));
        }

        //[HttpPost("refreshTokens")]
        //public async Task<IActionResult> RefreshTokens(UserTokens tokens)
        //{
        //    return Ok(await accountsService.RefreshTokens(tokens));
        //}

        [HttpPost("logout")]
        //public async Task<IActionResult> Logout(LogoutModel model)
        public async Task<IActionResult> Logout()
        {
            //await accountsService.Logout(model.RefreshToken);
            await accountsService.Logout();
            return Ok();
        }
    }
}
