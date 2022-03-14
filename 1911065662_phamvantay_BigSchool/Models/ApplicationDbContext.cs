using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _1911065662_phamvantay_BigSchool.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace _1911065662_phamvantay_BigSchool.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public ApplicationDbContext()
             : base("DefaultConnection", throwIfV1Schema: false)
        { }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        
    }

}