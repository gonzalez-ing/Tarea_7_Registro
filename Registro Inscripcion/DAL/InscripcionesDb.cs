using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Registro_Inscripcion.Entidades;

namespace Registro_Inscripcion.DAL
{
    public class InscripcionesDb : DbContext
    {
        public InscripcionesDb() : base("ConStr")
        {

        }

        public DbSet<Inscripciones> Inscripcion { set; get; }
    }
}
