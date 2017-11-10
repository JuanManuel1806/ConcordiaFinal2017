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
        public static List<Usuario> usuarios = new List<Usuario>();
        // GET: /MisUsuarios/Usuarios

        public ActionResult Index()
        {
            return View(usuarios);
        }

        // GET: /MisUsuarios/Usuarios

        public ActionResult Usuarios()
        {
            Usuario usuarios = new Usuario();

            var tiposDocumento = new List<Tipodocumento>();
            tiposDocumento.Add(new Tipodocumento()
            {
                IdTipodocumento = 1,
                Nombre = "Cedula de Ciudadania"
            });
            tiposDocumento.Add(new Tipodocumento()
            {
                IdTipodocumento = 2,
                Nombre = "Tarjeta de identidad"
            });
            tiposDocumento.Add(new Tipodocumento()
            {
                IdTipodocumento = 1,
                Nombre = "Registro Civil"
            });
            tiposDocumento.Add(new Tipodocumento()
            {
                IdTipodocumento = 1,
                Nombre = "Cedula de Extranjeria"
            });

            ViewBag.TiposDocumento =
                tiposDocumento.Select(x => new SelectListItem
                {
                    Text = x.Nombre,
                    Value = x.IdTipodocumento.ToString()
                });

            return View(usuarios);
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
                usuarios.Add(usuario);
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
            usuarios.Add(usuario);
            return View("Index");

        }
    }
}
