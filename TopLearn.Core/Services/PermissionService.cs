using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopLearn.Core.Services.InterFaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services
{
    public class PermissionService : IPermissionService
    {
        private TopLearnContext _context;
        public PermissionService(TopLearnContext context)
        {
            _context = context;
        }

        public void AddRolesToUser(List<int> roleIds, int userId)
        {
            foreach(var roleId in roleIds)
            {
                _context.userRoles.Add(new UserRole()
                {
                    RoleId = roleId,
                    UserId = userId
                });
            }

            _context.SaveChanges();
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
