using Concordia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace concordia.Controllers
{
    public class MisUsuariosController : Controller
    {
        //
        // GET: /MisUsuarios/Usuarios

        public ActionResult Usuarios()
        {
            return View();
        }
        //
        // GET: /MisUsuarios/Medicos

        public ActionResult Médicos()
        {
            return View();
        }

        //
        // GET: /MisUsuarios/Agenda
        public ActionResult Agenda()
        {
            return View();
        }

        //POST: /Usuario/Create/USANDOAJAX
        [HttpPost]
        public JsonResult CrearAJAX(Usuario usuario)
        {
            try
            {
                var json = Json(new { mensaje = "" });
                return json;
            }
            catch (Exception ex)
            {
                return Json(new { mensaje = ex.Message });
            }
        }
        //POST: /Usuario/Create/USANDOASUBMITTRADICIONAL

        [HttpPost]
        public ActionResult Crear(Usuario usuario)
        {
            return View();

        }
    }
}
