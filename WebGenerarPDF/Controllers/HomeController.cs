using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebGenerarPDF.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View("Principal");
        }
        public ActionResult Imprimir(E_Usuario usuario)
        {
            try
            {
                N_Usuario negocio = new N_Usuario();
                negocio.Imprimir(usuario);
            }
            catch (Exception ex)
            {
                TempData["ERROR"] = $"{ex.Message}";
            }
            return RedirectToAction("Index");
        }

    }
}