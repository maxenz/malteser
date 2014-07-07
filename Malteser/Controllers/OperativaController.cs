using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Malteser.Controllers
{
    [Authorize]
    public class OperativaController : Controller
    {
        //
        // GET: /Operativa/

        public ActionResult Index()
        {
            ViewBag.Title = "Control de la Operativa";
            return View();
        }

    }
}
