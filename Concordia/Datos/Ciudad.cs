using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concordia.Datos
{
         [Table("Ciudads")]
        public class Ciudad
        {
            public Ciudad()
            {
                this.Usuarios = new HashSet<Usuario>();
            }

            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.None)]
            public int IdCiudad { get; set; }
            public string Nombre { get; set; }

            public virtual ICollection<Usuario> Usuarios { get; set; }
        }
}