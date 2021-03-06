﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Concordia.Models
{
    public class Usuario
    {
        public TipoDocumento tipodocumento { get; set; }
        public string numerodedocumento { get; set; }
        public string primernombre { get; set; }
        public string segundonombre { get; set; }
        public string primerapellido { get; set; }
        public string segundoapellido { get; set; }
        public DateTime? fechadenacimiento { get; set; }
        public string Sexo { get; set; }
        public string telefono { get; set; }
        public Departamento departamento { get; set; }
        public Ciudad ciudad { get; set; }
        public string direccion { get; set; }
        public string analisis { get; set; }
        public string revisiones { get; set; }
        public string medicamentostomados { get; set; }
        public string alergiassufridas { get; set; }
        public string enfermedadespadecidas { get; set; }
        public long IdUsuario { get; set; }        
        public int Departamento { get; set; }
        public int Ciudad { get; set; }
    }
}