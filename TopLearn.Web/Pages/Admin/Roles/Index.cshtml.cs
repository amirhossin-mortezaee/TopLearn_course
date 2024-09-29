using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.DTOs;
using TopLearn.Core.Services.InterFaces;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Web.Pages.Admin.Roles
{
    public class IndexModel : PageModel
    {
        private IPermissionService _PermissionService;
        public IndexModel(IPermissionService PermissionService)
        {
            _PermissionService = PermissionService;
        }

        public List<Role> RoleList { get; set; }
        public void OnGet()
        {
            RoleList = _PermissionService.GetRoles();
        }
    }
}
