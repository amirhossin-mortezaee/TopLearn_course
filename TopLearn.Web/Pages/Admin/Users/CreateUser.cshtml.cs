using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.DTOs;
using TopLearn.Core.Security;
using TopLearn.Core.Services.InterFaces;

namespace TopLearn.Web.Pages.Admin.Users
{
    [PermissionChecker(3)]
    public class CreateUserModel : PageModel
    {
        private IUserService _userService;
        private IPermissionService _PermissionService;
        public CreateUserModel(IUserService userService , IPermissionService permissionService)
        {
            _userService = userService;
            _PermissionService = permissionService;
        }
        [BindProperty]
        public CreateUserViewModel createUserViewModel { get; set; }
        public void OnGet()
        {
            ViewData["Roles"] = _PermissionService.GetRoles();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            int userId = _userService.AddUserFromAdmin(createUserViewModel);

            //Add roles
            _PermissionService.AddRolesToUser(SelectedRoles, userId);

            return Redirect("/Admin/Users");
        }
    }
}
