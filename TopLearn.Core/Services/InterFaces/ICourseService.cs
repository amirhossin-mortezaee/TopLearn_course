using System;
using System.Collections.Generic;
using System.Text;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.Core.Services.InterFaces
{
    public interface ICourseService
    {
        #region Group

        List<CourseGroup> GetAllGroup();

        #endregion
    }
}
