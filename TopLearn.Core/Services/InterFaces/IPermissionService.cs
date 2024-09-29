using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services.InterFaces
{
    public interface IPermissionService
    {
        #region Roles
        List<Role> GetRoles();
        int AddRole(Role role);
        Role GetRoleById(int RoleId);
        void UpdateRole(Role role);
        void DeleteRole(Role Role);
        void AddRolesToUser(List<int> roleIds, int userId);
        void EditRolesUser(int userId, List<int> rolesId);
        #endregion
    }
}
