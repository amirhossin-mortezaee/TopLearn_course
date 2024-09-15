﻿using System;
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
        bool ActiveAccount(string activeCode);

    }
}
