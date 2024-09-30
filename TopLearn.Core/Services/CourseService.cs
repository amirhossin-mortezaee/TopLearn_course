using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public List<CourseGroup> GetAllGroup()
        {
            return _Context.CourseGroup.ToList();
        }
    }
}
