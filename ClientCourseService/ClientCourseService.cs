using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientCourseService
{
    public class ClientCourseService
    {
        private ClientCourseDataModelDataContext dbContext = new ClientCourseDataModelDataContext();

        public IEnumerable<Portal> GetPortals()
        {
            var portals = dbContext.Portals;
            return portals;
        }

        public Portal GetPortal(int portalId)
        {
            var portal = dbContext.Portals.FirstOrDefault(p=> p.portal_id==portalId);
            return portal;
        }

        public CoursePortal GetCoursePortal(int coursePortalId)
        {
            var coursePortal = dbContext.CoursePortals.FirstOrDefault(p => p.course_portal_id == coursePortalId);
            return coursePortal;
        }
    }
}
