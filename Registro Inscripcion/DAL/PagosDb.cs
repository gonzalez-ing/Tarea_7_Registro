using Registro_Inscripcion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Registro_Inscripcion.DAL
{
    public class PagosDb : DbContext
    {
        public DbSet<PagosDb> pagos { get; set; }

        public PagosDb() : base ("ConStr")
        {

        }
    }
}
