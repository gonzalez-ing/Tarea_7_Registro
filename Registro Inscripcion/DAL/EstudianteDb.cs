using Registro_Inscripcion.Entidades;
using RegistroPago.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Registro_Inscripcion.DAL
{

    public class EstudiantesDb : DbContext
    {
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Pagos> pagos { get; set; }
        public DbSet<Inscripciones> Inscripcion { set; get; }

        public EstudiantesDb() : base("ConStr")
        {

        }
    }
}

