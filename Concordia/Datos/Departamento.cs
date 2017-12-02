using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Concordia.Datos
{
    [Table("Departamentos")]
    public class Departamento
    {
        public Departamento()
        {
            this.Usuarios = new HashSet<Usuario>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDepartamento { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
   }
}