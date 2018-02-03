using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Registro_Inscripcion.DAL;
using Registro_Inscripcion.Entidades;


namespace Registro_Inscripcion.BLL
{
    class InscripcionesBLL
    {
        public static bool Guardar(Inscripciones inscrip)
        {
            bool flag = false;
            try
            {
                InscripcionesDb db = new InscripcionesDb();

                db.Inscripciones.Add(inscrip);
                db.SaveChanges();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static Inscripciones Buscar(int inscripId)
        {
            Inscripciones inscripcion = null;
            try
            {
                InscripcionesDb db = new InscripcionesDb();

                inscripcion = db.Inscripciones.Find(inscripId);
            }
            catch (Exception)
            {
                throw;
            }

            return inscripcion;
        }


        public static bool Modificar(Inscripciones inscrip)
        {
            bool flag = false;
            try
            {
                InscripcionesDb db = new InscripcionesDb();

                db.Entry(inscrip).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }



        public static bool Eliminar(int inscripId)
        {
            Inscripciones inscripcion = null;
            bool flag = false;

            try
            {
                InscripcionesDb db = new InscripcionesDb();

                inscripcion = Buscar(inscripId);
                db.Inscripciones.Remove(inscripcion);
                db.SaveChanges();

                flag = true;
            }
            catch (Exception)
            {
                throw;
            }

            return flag;
        }

        public static List<Inscripciones> GetList(Expression<Func<Inscripciones, bool>> filter)
        {
            List<Inscripciones> lista = null;
            try
            {
                InscripcionesDb db = new InscripcionesDb();

                lista = db.Inscripciones.Where(filter).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return lista;
        }

    }
}
