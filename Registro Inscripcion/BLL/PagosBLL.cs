using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_Inscripcion.Entidades;
using Registro_Inscripcion.DAL;
using System.Linq.Expressions;
using System.Windows.Forms;
using RegistroPago.Entidades;

namespace Registro_Inscripcion.BLL
{
   public class PagosBLL
    {
        public static bool Guardar(Pago pago)
        {
            bool estado = false;
            if (pago != null)
            {
                try
                {
                    PagosDb context = new PagosDb();
                    context.pagos.Add(context);
                    context.SaveChanges();
                    estado = true;

                }
                catch (Exception)
                {

                    throw;
                }
            }
            return estado;
        }

        public static Pago Buscar(int Id)
        {
            Pago estudiantes = new Pago();
            try
            {
                PagosDb context = new PagosDb();
                estudiantes = context.Pagos.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return estudiantes;

        }

        public static bool eliminar(int Id)
        {
            Pago pago = null;
            bool estado = false;
            try
            {
               EstudiantesDb context = new EstudiantesDb();
                pago = context.pagos.Find(Id);
                context.pagos.Remove(pago);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }

        public static List<Pagos> GetList(Expression<Func<Pagos, bool>> filter)
        {
            List<Pagos> lista = null;

            try
            {
                PagosDb db = new PagosDb();
                lista = db.Pagos.Where(filter).ToList();
            }
            catch (Exception)
            {
                throw;

            }

            if (!lista.Any())
            {
                MessageBox.Show("No se encontraron datos");
            }

            return lista;
        }

    }
}
