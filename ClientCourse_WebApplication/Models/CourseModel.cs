using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientCourse_WebApplication.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public int PortalId { get; set; }
        public string CourseName { get; set; }
        public List<RegistrationModel> Registrations { get; set; }
    }
}