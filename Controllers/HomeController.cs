using Saml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SAML_Example.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            var samlEndpoint = "https://is.colman.ac.il/nidp/saml2/sso";

            var request = new AuthRequest(
                "https://test3.millenium.org.il",
                "http://localhost:62571/Home/Contact"
                );

            //"https://login.colman.ac.il/AGLogout"
            //redirect the user to the SAML provider
            //var x = request.GetRedirectUrl(samlEndpoint);
            return Redirect(request.GetRedirectUrl(samlEndpoint));
            //ViewBag.Message = "Your application description page.";

            //return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}