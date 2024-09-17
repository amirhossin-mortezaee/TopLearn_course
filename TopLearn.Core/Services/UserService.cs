using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TopLearn.Core.Convertors;
using TopLearn.Core.DTOs;
using TopLearn.Core.Generator;
using TopLearn.Core.Security;
using TopLearn.Core.Services.InterFaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.User;

namespace TopLearn.Core.Services
{
    public class UserService : IUserService
    {
        private TopLearnContext _context;
        public UserService(TopLearnContext context)
        {
            _context = context;
        }

        public bool ActiveAccount(string activeCode)
        {
            var user = _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
            if(user == null || user.IsActive)
            {
                return false;
            }

            user.IsActive = true;
            user.ActiveCode = NameGenerator.GenerateUniqCode();
            _context.SaveChanges();
            return true;

        }

        public int AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return user.UserId;
        }

        public void ChangeUserPassword(string userName, string newPassword)
        {
            var user = GetUserByUserName(userName);
            user.PassWord = PasswordHelper.EncodePasswordMd5(newPassword);
            UpdateUser(user);
        }

        public bool CompareOldPassword(string oldPassword, string username)
        {
            string hashOldPassword = PasswordHelper.EncodePasswordMd5(oldPassword);
            return _context.Users.Any(u => u.UserName == username && u.PassWord == hashOldPassword);
        }

        public void EditProfile(string username ,EditProfileViewModel profile)
        {
            if(profile.UserAvatar != null)
            {
                string imagePath = "";
                if(profile.AvatarName != "Defult.jpg")
                {
                    imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                }

                profile.AvatarName = NameGenerator.GenerateUniqCode() + Path.GetExtension(profile.UserAvatar.FileName);
                imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/UserAvatar", profile.AvatarName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    profile.UserAvatar.CopyTo(stream);
                }

            }

            var user = GetUserByUserName(username);
            user.UserName = profile.UserName;
            user.Email = profile.Email;
            user.UserAvatar = profile.AvatarName;

            UpdateUser(user);
        }

        public EditProfileViewModel GetDataForEditProfileUser(string username)
        {
            return _context.Users.Where(u => u.UserName == username).Select(u => new EditProfileViewModel()
            {
                Email = u.Email,
                UserName = u.UserName,
                AvatarName = u.UserAvatar
            }).Single();
        }

        public SideBarUserPanelViewModel GetSideBarUserPanelData(string username)
        {
            return _context.Users.Where(u => u.UserName == username).Select(u => new SideBarUserPanelViewModel()
            {
                UserName = u.UserName,
                ImageName = u.UserAvatar,
                RegisterDate = u.RegisterDate
            }).Single();
        }

        public User GetUserByActiveCode(string activeCode)
        {
            return _context.Users.SingleOrDefault(u => u.ActiveCode == activeCode);
        }

        public User GetUserByEmail(string Email)
        {
            return _context.Users.SingleOrDefault(u => u.Email == Email);
        }

        public User GetUserByUserName(string username)
        {
            return _context.Users.SingleOrDefault(u => u.UserName == username);
        }

        public InformationUserViewModel GetUserInformation(string username)
        {
            var user = GetUserByUserName(username);
            InformationUserViewModel information = new InformationUserViewModel();
            information.UserName = username;
            information.Email = user.Email;
            information.RegisterDate = user.RegisterDate;
            information.Wallet = 0;

            return information;
        }

        public bool ISExistEmail(string email)
        {
            return _context.Users.Any(u => u.Email == email);
        }

        public bool IsExistUserName(string userName)
        {
            return _context.Users.Any(u => u.UserName == userName);
        }

        public User LoginUser(LoginViewModel login)
        {
            string hashPassWord = PasswordHelper.EncodePasswordMd5(login.PassWord);
            string email = FixedText.FixEmail(login.Email);
            return _context.Users.SingleOrDefault(u => u.Email == email && u.PassWord == hashPassWord);
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
