using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClientCourse_WebApplication.Models;

namespace ClientCourse_WebApplication.Controllers
{

    public class CourseController : Controller
    {
        ClientCourseService.ClientCourseService service = new ClientCourseService.ClientCourseService();

        // GET: Course
        public ActionResult Index()
        {
            return View();
        }

        // GET: Course/Details/5
        public ActionResult Details(int id)
        {
            var courseportal = service.GetCoursePortal(id);
            var courseModel = new CourseModel()
            {
                Id = courseportal.course_portal_id,
                CourseName = courseportal.course_portal_nm,
                PortalId = courseportal.portal_id

            };
            var registrationModels = new List<RegistrationModel>();
            foreach (var registration in courseportal.Registrations)
            {
                var registrationModel = new RegistrationModel()
                {
                    Id = registration.registration_id,
                    CourseId = registration.course_portal_id,
                    RegistartionDateTime = registration.registration_dttm,
                    User = new UserModel()
                    {
                        UserId = registration.User.user_id,
                        FirstName = registration.User.first_nm,
                        LastName = registration.User.last_nm
                    }
                };
                registrationModels.Add(registrationModel);
            }
            courseModel.Registrations = registrationModels;
            return View(courseModel);
        }

     
    }
}
