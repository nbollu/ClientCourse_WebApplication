using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientCourse_WebApplication.Models
{
    public class RegistrationModel
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public UserModel User { get; set; }
        public DateTime RegistartionDateTime { get; set; }
    }
}