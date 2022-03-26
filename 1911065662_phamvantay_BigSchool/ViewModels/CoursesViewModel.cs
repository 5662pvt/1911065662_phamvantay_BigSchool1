using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _1911065662_phamvantay_BigSchool.Models;

namespace _1911065662_phamvantay_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }      
        public bool ShowAction { get; set; }
    }
}