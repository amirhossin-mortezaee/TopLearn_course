using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TopLearn.Core.Security;
using TopLearn.Core.Services.InterFaces;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.Web.Pages.Admin.Courses
{
    [PermissionChecker(11)]
    public class CreateCourseModel : PageModel
    {
        private ICourseService _CourseService;
        public CreateCourseModel(ICourseService CourseService)
        {
            _CourseService = CourseService;
        }

        [BindProperty]
        public Course Course { get; set; }
        public void OnGet()
        {
            var Groups = _CourseService.GetGroupForManageCourse();
            ViewData["Groups"] = new SelectList(Groups,"Value","Text");

            var SubGroups = _CourseService.GetSubGroupForManageCourse(int.Parse(Groups.First().Value));
            ViewData["SubGroups"] = new SelectList(SubGroups, "Value", "Text");

            var Teachers = _CourseService.GetTeachers();
            ViewData["Teachers"] = new SelectList(Teachers, "Value", "Text");

            var Levels = _CourseService.GetLevels();
            ViewData["Levels"] = new SelectList(Levels, "Value", "Text");

            var Statues = _CourseService.GetStatues();
            ViewData["Statues"] = new SelectList(Statues, "Value", "Text");
        }

        public IActionResult OnPost(IFormFile imgCourseUp , IFormFile demoUp)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _CourseService.AddCourse(Course, imgCourseUp , demoUp);

            return RedirectToPage("Index");

        }
    }
}
