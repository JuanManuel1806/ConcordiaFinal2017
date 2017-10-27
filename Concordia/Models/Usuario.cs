using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Concordia.Models
{
    public class Usuario
    {
        public string tipodedocumento { get; set; }
        public string numerodedocumento { get; set; }
        public string primernombre { get; set; }
        public string segundonombre { get; set; }
        public string primerapellido { get; set; }
        public string segundoapellido { get; set; }
        public DateTime fechadenacimiento { get; set; }
    }
}