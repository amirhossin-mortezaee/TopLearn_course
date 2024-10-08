﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.InterFaces;

namespace TopLearn.Web.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class HomeController : Controller
    {
        private IUserService _userService;
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View(_userService.GetUserInformation(User.Identity.Name));
        }
        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile()
        {
            return View(_userService.GetDataForEditProfileUser(User.Identity.Name));
        }

        [Route("UserPanel/EditProfile")]
        [HttpPost]
        public IActionResult EditProfile(EditProfileViewModel profile)
        {
            if (!ModelState.IsValid)
                return View(profile);

            _userService.EditProfile(User.Identity.Name,profile);

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            ViewBag.IsSuccess = true;
            return Redirect("/Login?EditProfile=true");
        }

        [Route("UserPanel/changePassword")]
        public IActionResult changePassword()
        {
            return View();
        }

        [Route("UserPanel/changePassword")]
        [HttpPost]
        public IActionResult changePassword(ChangePasswordViewModel change)
        {
            string currentUserName = User.Identity.Name;
            if (!ModelState.IsValid)
                return View(change);

            if (!_userService.CompareOldPassword(change.oldPassWord, currentUserName))
            {
                ModelState.AddModelError("oldPassWord", "کلمه عبور فعلی صحیح نمی باشد");
                return View(change);
            }

            _userService.ChangeUserPassword(currentUserName,change.PassWord);
            ViewBag.IsSuccess = true;

            return View();
        }
    }
}
