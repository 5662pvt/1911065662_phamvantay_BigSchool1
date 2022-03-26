using _1911065662_phamvantay_BigSchool.DTOs;
using _1911065662_phamvantay_BigSchool.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace _1911065662_phamvantay_BigSchool.Controllers
{
    public class FollowingsController : Controller
    {
        // GET: Followings
        public ActionResult Index()
        {
            return View();
        }

        private readonly ApplicationDbContext _dbContext;
        public FollowingsController()
        {
            _dbContext = new ApplicationDbContext();
        }

        //[System.Web.Http.HttpPost]
        //public IHttpActionResult Follow(FollowingDto followingDto)
        //{
        //    var userId = User.Identity.GetUserId();
        //    if (_dbContext.Followings.Any(f => f.FollowerId == userId && f.FolloweeId == followingDto.FolloweeId))
        //    {
        //        return BadRequest("Following already exists!");
        //    }
           
        //    var folowing = new Following
        //    {
        //        FollowerId = userId,
        //        FolloweeId = followingDto.FolloweeId
        //    };
        //    _dbContext.Followings.Add(folowing);
        //    _dbContext.SaveChanges();
        //    return Ok();
        //}
    }
}