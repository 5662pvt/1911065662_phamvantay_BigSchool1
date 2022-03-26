using _1911065662_phamvantay_BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace _1911065662_phamvantay_BigSchool.Controllers
{

    [Authorize]
    public class AttendancesController : ApiController
    {
     private ApplicationDbContext _dbContext;
        public AttendancesController()
        {
           _dbContext = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult Attend([FromBody] int courseId)
        {
            var attendance = new Attendances
            {
                CourseId = courseId,
                AttendeeId = User.Identity.GetUserId()
            };
            _dbContext.Attendance.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
