using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TopLearn.Core.Services.InterFaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.Permissions;
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

        public void AddPermissionsToRole(int RoleId, List<int> permission)
        {
            foreach (var p in permission)
            {
                _context.RolePermission.Add(new RolePermission()
                {
                    PermissionId = p,
                    RoleId = RoleId
                });
            }

            _context.SaveChanges();
        }

        public int AddRole(Role role)
        {
            _context.Roles.Add(role);
            _context.SaveChanges();
            return role.RoleId;
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

        public bool CheckPermission(int permissionId, string userName)
        {
            int userId = _context.Users.Single(u => u.UserName == userName).UserId;

            List<int> UserRoles = _context.userRoles
                .Where(u => u.UserId == userId).Select(u => u.RoleId).ToList();

            if(!UserRoles.Any())
            {
                return false;
            }

            List<int> RolesPermission = _context.RolePermission
                .Where(p => p.PermissionId == permissionId)
                .Select(p => p.RoleId).ToList();

            return RolesPermission.Any(p => UserRoles.Contains(p));
        }

        public void DeleteRole(Role Role)
        {
            Role.IsDelete = true;
            UpdateRole(Role);
        }

        public void EditRolesUser(int userId, List<int> rolesId)
        {
            //حذف رول های قدیمی
            _context.userRoles.Where(r => r.UserId == userId).ToList().ForEach(r => _context.userRoles.Remove(r));

            //اضافه کردن رول جدید
            AddRolesToUser(rolesId, userId);
        }

        public List<Permission> GetAllPermission()
        {
            return _context.Permission.ToList();
        }

        public Role GetRoleById(int RoleId)
        {
            return _context.Roles.Find(RoleId);
        }

        public List<Role> GetRoles()
        {
            return _context.Roles.ToList();
        }

        public List<int> PermissionsRole(int RoleId)
        {
            return _context.RolePermission.Where(r => r.RoleId == RoleId)
                .Select(r => r.PermissionId)
                .ToList();
        }

        public void UpdatePermissionRole(int RoleId, List<int> permissions)
        {
            _context.RolePermission.Where(p => p.RoleId == RoleId)
                .ToList().ForEach(p => _context.RolePermission.Remove(p));

            AddPermissionsToRole(RoleId , permissions);
        }

        public void UpdateRole(Role role)
        {
            _context.Roles.Update(role);
            _context.SaveChanges();
        }
    }
}
