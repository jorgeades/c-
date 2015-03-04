using System.Linq;
using System.Web.Mvc;
using Alumnos.Models;

namespace Alumnos.Controllers
{
    public class HomeController : Controller
    {



        // GET: Home
        public ActionResult Index()
        {
            using (var db = new CursosEntities())
            {
                return View(db.Alumnos.ToList());
            }

        }


        public ActionResult Alta()
        {

            return View(new Models.Alumnos());
        }

        [HttpPost]
        public ActionResult Alta(Models.Alumnos model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new CursosEntities())
                {
                    db.Alumnos.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return View(model);


        }





    }
}