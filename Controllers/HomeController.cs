using PocMySQL.Domain;
using System.Linq;
using System.Web.Mvc;

namespace PocMySQL.Controllers
{
    public partial class HomeController : Controller        
    {
        public virtual ActionResult Index()
        {
            using (var dbContext = new StoreContext())
            {
                var store = dbContext.Stores.FirstOrDefault();
                var model = store.Name + " loaded from dbcontext: " + dbContext.Guid;
                return Content(model);
            }
        }
    }
}
