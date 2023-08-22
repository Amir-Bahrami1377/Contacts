using System.Collections.Generic;
using System.Web.Routing;

namespace Contacts.ViewModels
{
    public class BaseListVM<Entity>
    {
        public List<Entity> Entities { get; set; }

        public RouteValueDictionary RouteDictionary { get; set; }
    }
}