using CleanArch.Domain1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain1.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}
