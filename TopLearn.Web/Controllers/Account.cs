using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.Convertors;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.InterFaces;

namespace TopLearn.Web.Controllers
{
    public class Account : Controller
    {

        private IUserService _userService;
        public Account(IUserService userService)
        {
            userService = _userService;
        }
        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
            {
                return View(register);
            }

            if (_userService.IsExistUserName(register.UserName))
            {
                ModelState.AddModelError("userName", "نام کاربری وارد شده معتبر نمی باشد");
                return View(register);
            }

            if (_userService.ISExistEmail(FixedText.FixEmail(register.Email)))
            {
                ModelState.AddModelError("Email", "ایمیل وارد شده معتبر نمی باشد");
                return View(register);
            }
            return View();
        }
    }
}
