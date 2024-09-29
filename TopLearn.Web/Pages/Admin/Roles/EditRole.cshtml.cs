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
    public class EditRoleModel : PageModel
    {
        private IPermissionService _PermissionService;
        public EditRoleModel(IPermissionService PermissionService)
        {
            _PermissionService = PermissionService;
        }

        [BindProperty]
        public Role Role { get; set; }
        public void OnGet(int id)
        {
            Role = _PermissionService.GetRoleById(id);
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _PermissionService.UpdateRole(Role);

            return RedirectToPage("Index");
        }
    }
}
