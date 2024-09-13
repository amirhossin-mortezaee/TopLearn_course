using System;
using System.Collections.Generic;
using System.Text;

namespace TopLearn.Core.Services.InterFaces
{
    public interface IUserService
    {
        bool IsExistUserName(string userName);
        bool ISExistEmail(string email);
    }
}
