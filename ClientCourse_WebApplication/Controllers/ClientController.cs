using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using System.Web.Mvc;
using ClientCourse_WebApplication.Models;

namespace ClientCourse_WebApplication.Controllers
{
    public class ClientController : Controller
    {

        ClientCourseService.ClientCourseService service = new ClientCourseService.ClientCourseService();

        // GET: Client
        public ActionResult Index()
        {
            var portals = service.GetPortals();
            var clientModels = new List<ClientModel>();
            foreach (var portal in portals)
            {
                var clientModel = new ClientModel()
                {
                    Id = portal.portal_id,
                    Name = portal.portal_nm
                };
                clientModels.Add(clientModel);
            }
            return View(clientModels);
        }

        // GET: Client/Details/5
        public ActionResult Details(int id)
        {
            var portal = service.GetPortal(id);
           var clientModel = new ClientModel()
            
                {
                    Id = portal.portal_id,
                    Name = portal.portal_nm,
                };
            clientModel.Courses = new List<CourseModel>();

            foreach (var courseportal in portal.CoursePortals)
            {
                var courseModel = new CourseModel()
                {
                    Id = courseportal.course_portal_id,
                    PortalId = portal.portal_id,
                    CourseName = courseportal.course_portal_nm

                };
                clientModel.Courses.Add(courseModel);
            }
            return View(clientModel);
        }
               
    }
}
