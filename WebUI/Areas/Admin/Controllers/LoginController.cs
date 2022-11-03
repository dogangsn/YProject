using DataAccess.Abstract;
using Entities.Dtos;
using Helpers.Entities;
using Helpers.Enums;
using Helpers.Messages;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Entities.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using Helpers.Settings;
using System.Collections.Generic;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly IUserDal _userDal;
        private readonly IConfiguration _configuration;
        public LoginController(IUserDal userDal)
        {
            _userDal = userDal;
        }
         
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SignIn(LoginDto model)
        {

            var user = _userDal.CheckLogin(model.UserName, model.Password);
            NResult<UserLoginDto> nResult = new NResult<UserLoginDto>();


            if (user == null)
            {
                nResult.Message = "Kullanıcı adı veya parola yanlış!";
                nResult.ResponseType = ResponseType.Error;
            }
            else
            {
                nResult.Data = new UserLoginDto() { UserId = user.UserId, UserName = user.UserName, FirstName = user.FirstName, LastName = user.LastName };
                nResult.Message = Message.Success;
                nResult.Token = Functions.Enigma(user.UserId + "," + user.Email + "," + DateTime.Now, PasswordType.Encrypt);
                nResult.ResponseType = ResponseType.Success;
                var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, nResult.Data.UserId.ToString()) }, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
            }


            return Json(nResult);
        }
        public IActionResult SignOut()
        { 
            HttpContext.SignOutAsync();
            return Redirect("/admin/login/index");
        }
    }
}
