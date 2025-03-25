using System.Web.Mvc;

namespace IGRedSocial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Registro()
        {
            return View();
        }

        public ActionResult Olvide()
        {
            return View();
        }
    }
}