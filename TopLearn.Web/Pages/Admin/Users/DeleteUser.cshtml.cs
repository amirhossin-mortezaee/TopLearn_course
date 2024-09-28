using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.InterFaces;

namespace TopLearn.Web.Pages.Admin.Users
{
    public class DeleteUserModel : PageModel
    {
        private IUserService _userService;
        public DeleteUserModel(IUserService userService)
        {
            _userService = userService;
        }

        public InformationUserViewModel informationUserViewModel { get; set; }
        public void OnGet(int id)
        {
            ViewData["UserId"] = id;
            informationUserViewModel = _userService.GetUserInformation(id);

        }

        public IActionResult OnPost(int UserId)
        {
            _userService.DeleteUser(UserId);
            return RedirectToPage("Index");
        }
    }
}
