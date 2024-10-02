using System;
using System.Collections.Generic;
using System.Text;

namespace TopLearn.Core.DTOs.Course
{
    public class ShowCourseForAdminVewModel
    {
        public int CourseId { get; set; }
        public string Tirle { get; set; }
        public string ImageName { get; set; }
        public int EpisodeCount { get; set; }
    }
}
