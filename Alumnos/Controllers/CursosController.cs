using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Alumnos.Models;

namespace Alumnos.Controllers
{
    public class CursosController : Controller
    {

        CursosEntities db=new CursosEntities();



        // GET: Cursos
        public ActionResult Index()
        {

            return View(db.Curso);
        }


        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            db.Dispose();
        }
    }
}