using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClientCourse_WebApplication.Models
{
    public class ClientModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CourseModel> Courses { get; set; }
    }
}