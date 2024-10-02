using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TopLearn.Core.DTOs.Course;
using TopLearn.Core.Generator;
using TopLearn.Core.Services.InterFaces;
using TopLearn.DataLayer.Context;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.Core.Services
{
    public class CourseService : ICourseService
    {
        private TopLearnContext _Context;

        public CourseService(TopLearnContext Context)
        {
            _Context = Context;
        }

        public int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo)
        {
            course.CreateDate = DateTime.Now;
            course.CourseImageName = "no-photo.jpg";
            if(imgCourse != null)
            {
               course.CourseImageName = SaveImage(imgCourse);
            }

            _Context.Add(course);
            _Context.SaveChanges();
            return course.CourseId;
        }

        public List<CourseGroup> GetAllGroup()
        {
            return _Context.CourseGroup.ToList();
        }

        public List<ShowCourseForAdminVewModel> GetCoursesForAdmin()
        {
            return _Context.Courses.Select(c => new ShowCourseForAdminVewModel()
            {
                CourseId = c.CourseId,
                Tirle = c.CourseTitle,
                ImageName = c.CourseImageName,
                EpisodeCount = c.CourseEpisodes.Count()
            }).ToList();
        }

        public List<SelectListItem> GetGroupForManageCourse()
        {
            return _Context.CourseGroup.Where(g => g.ParenId == null)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<SelectListItem> GetLevels()
        {
            return _Context.CourseLevels.Select(l => new SelectListItem()
            {
                Value = l.LevelId.ToString(),
                Text = l.LevelTitle
            }).ToList();
        }

        public List<SelectListItem> GetStatues()
        {
            return _Context.CourseStatuses.Select(s => new SelectListItem()
            {
                Value = s.StatusId.ToString(),
                Text = s.StatusTitle
            }).ToList();
        }

        public List<SelectListItem> GetSubGroupForManageCourse(int GroupId)
        {
            return _Context.CourseGroup.Where(g => g.ParenId == GroupId)
            .Select(g => new SelectListItem()
            {
                Text = g.GroupTitle,
                Value = g.GroupId.ToString()
            }).ToList();
        }

        public List<SelectListItem> GetTeachers()
        {
            return _Context.userRoles.Where(r => r.RoleId == 2).Include(r => r.User)
                .Select(u => new SelectListItem()
                {
                    Text = u.User.UserName,
                    Value = u.UserId.ToString()
                }).ToList();
        }

        public string SaveImage(IFormFile Img)
        {
            string imageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(Img.FileName);
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Course/Image", imageName);

            using (var stream = new FileStream(imagePath, FileMode.Create))
            {
                Img.CopyTo(stream);
            }

            return imageName;
        }
    }
}
