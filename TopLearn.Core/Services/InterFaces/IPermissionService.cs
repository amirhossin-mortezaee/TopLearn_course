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

        void AddRolesToUser(List<int> roleIds, int userId);
        #endregion
    }
}
