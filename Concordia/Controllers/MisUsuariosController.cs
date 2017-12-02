using Concordia.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Concordia.Controllers
{
    // [Authorize]
    public class MisUsuariosController : Controller
    {
        private static Datos.OngContext contexto = new Datos.OngContext();

        // GET: /MisUsuarios/Usuarios
        public ActionResult Index()
        {
            var usuarios = contexto.Usuarios.Select(u => new Usuario()
            {
                IdUsuario = u.IdUsuario,
                numerodedocumento = u.numerodedocumento,
                primernombre = u.primernombre,
                segundonombre = u.segundonombre,
                primerapellido = u.primerapellido,
                segundoapellido = u.segundoapellido,
                Sexo = u.Sexo,
                telefono = u.telefono,
                direccion = u.direccion,
                analisis = u.analisis,
                revisiones = u.revisiones,
                medicamentostomados = u.medicamentostomados,
                alergiassufridas = u.alergiassufridas,
                enfermedadespadecidas = u.enfermedadespadecidas,
                tipodocumento = new TipoDocumento() { Nombre = u.TipoDocumento.Nombre },
                departamento = new Departamento() { Nombre = u.Departamento.Nombre },
                ciudad = new Ciudad() { Nombre = u.Ciudad.Nombre }
            }).ToList();

            return View(usuarios);
        }

        public ActionResult Usuarios()
        {
            Usuario usuario = new Usuario();

            var tiposDocumento = contexto.TiposDocumento.Select(u => new TipoDocumento() { IdTipodocumento = u.IdTipoDocumento, Nombre = u.Nombre }).ToList();

            ViewBag.TiposDocumento = tiposDocumento.Select(x => new SelectListItem
                {
                    Text = x.Nombre,
                    Value = x.IdTipodocumento.ToString()
                });

            return View();
        }
        public ActionResult CrearDepartamento()
        {
            Usuario usuario = new Usuario();

            var departamento = contexto.Departamentos.Select(u => new Departamento() { IdDepartamento = u.IdDepartamento, Nombre = u.Nombre }).ToList();

            ViewBag.Departamentos = departamento.Select(d => new SelectListItem
            {
                Text = d.Nombre,
                Value = d.IdDepartamento.ToString()
            });

            return View();
        }
        public ActionResult CrearCiudad()
        {
            Usuario usuario = new Usuario();

            var ciudad = contexto.Ciudads.Select(u => new Ciudad() { IdCiudad = u.IdCiudad, Nombre = u.Nombre }).ToList();

            ViewBag.Ciudads = ciudad.Select(c => new SelectListItem
            {
                Text = c.Nombre,
                Value = c.IdCiudad.ToString()
            });

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
                contexto.Usuarios.Add(new Datos.Usuario() 
                { 
                    IdTipoDocumento = usuario.tipodocumento.IdTipodocumento,
                    fechadenacimiento = usuario.fechadenacimiento.Value,
                     primernombre = usuario.primernombre,
                     segundonombre = usuario.segundonombre,
                     primerapellido = usuario.primerapellido,
                    segundoapellido =usuario.segundoapellido,
                    Sexo = usuario.Sexo,
                    telefono = usuario.telefono,
                    IdDepartamento = usuario.Departamento,
                    IdCiudad = usuario.Ciudad,
                    direccion = usuario.direccion,
                    analisis = usuario.analisis,
                    revisiones = usuario.revisiones,
                    medicamentostomados = usuario.medicamentostomados,
                    alergiassufridas = usuario.alergiassufridas,
                    enfermedadespadecidas = usuario.enfermedadespadecidas,
                });
                contexto.SaveChanges();

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
            contexto.Usuarios.Add(new Datos.Usuario()
            {
                IdTipoDocumento = usuario.tipodocumento.IdTipodocumento,
                fechadenacimiento = usuario.fechadenacimiento.Value,
                primernombre = usuario.primernombre,
                segundonombre = usuario.segundonombre,
                primerapellido = usuario.primerapellido,
                segundoapellido = usuario.segundoapellido,
                Sexo = usuario.Sexo,
                telefono = usuario.telefono,
                IdDepartamento = usuario.departamento.IdDepartamento,
                IdCiudad = usuario.ciudad.IdCiudad,
                direccion = usuario.direccion,
                analisis = usuario.analisis,
                revisiones = usuario.revisiones,
                medicamentostomados = usuario.medicamentostomados,
                alergiassufridas = usuario.alergiassufridas,
                enfermedadespadecidas = usuario.enfermedadespadecidas,
             });
            contexto.SaveChanges();

            var usuarios = contexto.Usuarios.Select(u => new Usuario()
            {
                IdUsuario = u.IdUsuario,
                fechadenacimiento = usuario.fechadenacimiento.Value,
                primernombre = u.primernombre,
                segundonombre = u.segundonombre,
                primerapellido = u.primerapellido,
                segundoapellido = u.segundoapellido,
                Sexo = u.Sexo,
                telefono = u.telefono,
                departamento = u.IdDepartamento,
                ciudad = u.IdCiudad,
                direccion = u.direccion,
                analisis = u.analisis,
                revisiones = u.revisiones,
                medicamentostomados = u.medicamentostomados,
                alergiassufridas = u.alergiassufridas,
                enfermedadespadecidas = u.enfermedadespadecidas,
            });

            return View("Index", usuarios);

        }
    }
}
