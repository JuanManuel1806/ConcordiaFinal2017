using Concordia.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Concordia.Datos
{
    public class Usuario
    {
        [Key]
        public long IdUsuario { get; set; }
        public int IdTipoDocumento { get; internal set; }
        public string numerodedocumento { get; set; }
        public string primernombre { get; set; }
        public string segundonombre { get; set; }
        public string primerapellido { get; set; }
        public string segundoapellido { get; set; }
        public DateTime fechadenacimiento { get; set; }
        public string Sexo { get; set; }
        public string telefono { get; set; }
        public int IdDepartamento { get; internal set; }
        public int IdCiudad { get; internal set; }
        public string direccion { get; set; }
        public string analisis { get; set; }
        public string revisiones { get; set; }
        public string medicamentostomados { get; set; }
        public string alergiassufridas { get; set; }
        public string enfermedadespadecidas { get; set; }


        public virtual TipoDocumento TipoDocumento { get; set; }
        public virtual Departamento Departamento { get; set; }
        public virtual Ciudad Ciudad { get; set; }

    }
}