using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Concordia.Datos
{
    public class OngInitializer :
        DropCreateDatabaseIfModelChanges<OngContext>
    {
        protected override void Seed (OngContext context)
        {
            context.TiposDocumento.Add(new TipoDocumento() {Nombre = "Cédula de Ciudadanía", IdTipoDocumento = 1});
            context.TiposDocumento.Add(new TipoDocumento() {Nombre = "Cédula de Extranjería", IdTipoDocumento = 2});
            context.TiposDocumento.Add(new TipoDocumento() {Nombre = "Tarjeta de Identidad", IdTipoDocumento = 3});
            context.TiposDocumento.Add(new TipoDocumento() {Nombre = "NUIP", IdTipoDocumento = 4});

            context.Departamentos.Add(new Departamento() { Nombre = "Antioquia", IdDepartamento = 1 });
            context.Departamentos.Add(new Departamento() { Nombre = "Bolivar", IdDepartamento = 2 });
            context.Departamentos.Add(new Departamento() { Nombre = "Cundinamarca", IdDepartamento = 3 });
            context.Departamentos.Add(new Departamento() { Nombre = "Magdalena", IdDepartamento = 4 });
            context.Departamentos.Add(new Departamento() { Nombre = "Santander", IdDepartamento = 5 });

            context.Ciudads.Add(new Ciudad() { Nombre = "Medellin", IdCiudad = 1 });
            context.Ciudads.Add(new Ciudad() { Nombre = "Cartagena", IdCiudad = 2 });
            context.Ciudads.Add(new Ciudad() { Nombre = "Bogota", IdCiudad = 3 });
            context.Ciudads.Add(new Ciudad() { Nombre = "Santa Marta", IdCiudad = 4 });
            context.Ciudads.Add(new Ciudad() { Nombre = "Bucaramanga", IdCiudad = 5 });


            base.Seed(context);
        }
    }
}