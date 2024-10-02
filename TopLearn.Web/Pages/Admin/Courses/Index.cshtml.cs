using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopLearn.Core.DTOs.Course;
using TopLearn.Core.Security;
using TopLearn.Core.Services.InterFaces;

namespace TopLearn.Web.Pages.Admin.Courses
{
    [PermissionChecker(10)]
    public class IndexModel : PageModel
    {
        private ICourseService _CourseService;
        public IndexModel(ICourseService CourseService)
        {
            _CourseService = CourseService;
        }

        public List<ShowCourseForAdminVewModel> ListCourse { get; set; }
        public void OnGet()
        {
            ListCourse = _CourseService.GetCoursesForAdmin();
        }
    }
}
