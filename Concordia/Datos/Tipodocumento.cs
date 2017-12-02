using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concordia.Datos
{
    [Table("TiposDocumento")]
    public class TipoDocumento
    {
        public TipoDocumento ()
        {
            this.Usuarios = new HashSet<Usuario>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoDocumento { get; set;}
        public string Nombre {get; set;}

        public virtual ICollection<Usuario> Usuarios { get; set;}
    }
}