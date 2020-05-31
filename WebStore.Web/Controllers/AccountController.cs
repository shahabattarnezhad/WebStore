using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Convertors;
using WebStore.Core.DTOs;
using WebStore.Core.Generator;
using WebStore.Core.Security;
using WebStore.Core.Services.Interfaces;
using WebStore.DataLayer.Entities.User;

namespace WebStore.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel registerViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(registerViewModel);
            }

            if (_userService.IsExistUserName(registerViewModel.UserName))
            {
                ModelState.AddModelError("UserName", "نام کاربری معتبر نیست");
                return View(registerViewModel);
            }

            if (_userService.IsExistEmail(FixedText.FixEmail(registerViewModel.UserEmail)))
            {
                ModelState.AddModelError("UserEmail","ایمیل معتبر نیست");
                return View(registerViewModel);
            }

            // TODO: REGISTER USER  

            User user = new User()
            {
                UserActiveCode = NameGenerator.GenerateUniqueCode(),
                UserEmail = FixedText.FixEmail(registerViewModel.UserEmail),
                UserName = registerViewModel.UserName,
                UserIsActive = false,
                UserPassword = PasswordHelper.EncodePasswordMD5(registerViewModel.UserPassword),
                UserRegisterDate = DateTime.Now,
                UserAvatar = "Default.jpg"
            };
            _userService.AddUser(user);


            return View("SuccessRegister",user);
        }

        
    }
}