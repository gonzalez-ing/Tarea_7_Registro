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
        public static bool Guardar(Pagos pago)
        {
            bool estado = false;
            if (pago != null)
            {
                try
                {
                    EstudiantesDb context = new EstudiantesDb();
                    context.pagos.Add(pago);
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

        public static Pagos Buscar(int Id)
        {
            Pagos pagos = new Pagos();
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                pagos = context.pagos.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return pagos;

        }

        public static bool eliminar(int Id)
        {
            Pagos pago = null;
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
                EstudiantesDb db = new EstudiantesDb();
                lista = db.pagos.Where(filter).ToList();
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
