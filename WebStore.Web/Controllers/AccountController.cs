using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Core.Convertors;
using WebStore.Core.DTOs;
using WebStore.Core.Services.Interfaces;

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
            return View();
        }
    }
}