using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.Services.InterFaces;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Web.Pages.Admin.Roles
{
    public class CreateRoleModel : PageModel
    {
        private IPermissionService _PermissionService;
        public CreateRoleModel(IPermissionService PermissionService)
        {
            _PermissionService = PermissionService;
        }

        [BindProperty]
        public Role Role { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            Role.IsDelete = false;
            int RoleId = _PermissionService.AddRole(Role);

            return RedirectToPage("Index");
        }
    }
}
