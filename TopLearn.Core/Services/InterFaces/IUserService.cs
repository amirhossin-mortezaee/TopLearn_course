using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.Core.DTOs;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services.InterFaces
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool ISExistEmail(string email);
        int AddUser(User user);
        User LoginUser(LoginViewModel login);
        User GetUserByEmail(string Email);
        User GetUserByUserName(string username);
        User GetUserByActiveCode(string activeCode);
        void UpdateUser(User user);
        bool ActiveAccount(string activeCode);

        #region UserPanel
        InformationUserViewModel GetUserInformation(string username);
        #endregion
    }
}
