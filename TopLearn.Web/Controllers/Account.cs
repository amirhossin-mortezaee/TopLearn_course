using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.Convertors;
using TopLearn.Core.DTOs;
using TopLearn.Core.Generator;
using TopLearn.Core.Security;
using TopLearn.Core.Services.InterFaces;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Web.Controllers
{
    public class Account : Controller
    {

        private IUserService _userService;
        public Account(IUserService userService)
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

            User user = new User()
            {
                ActiveCode = NameGenerator.GenerateUniqCode(),
                Email = FixedText.FixEmail(register.Email),
                IsActive = false,
                PassWord = PasswordHelper.EncodePasswordMd5(register.PassWord),
                RegisterDate = DateTime.Now,
                UserAvatar = "Defult.jpg",
                UserName = register.UserName
            };

            _userService.AddUser(user);
            return View("SuccessRegister",user);
        }
    }
}
