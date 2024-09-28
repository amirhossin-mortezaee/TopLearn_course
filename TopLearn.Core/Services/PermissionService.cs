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

        public void EditRolesUser(int userId, List<int> rolesId)
        {
            //حذف رول های قدیمی
            _context.userRoles.Where(r => r.UserId == userId).ToList().ForEach(r => _context.userRoles.Remove(r));

            //اضافه کردن رول جدید
            AddRolesToUser(rolesId, userId);
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }
    }
}
