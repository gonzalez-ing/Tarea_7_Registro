using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_Inscripcion.Entidades;
using Registro_Inscripcion.DAL;
using System.Windows.Forms;
using System.Data.Entity;

namespace Registro_Inscripcion.BLL
{
    class EstudiantesBLL
    {

        public static bool Guardar(Estudiantes estudiantes)
        {
            bool estado = false;
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                context.Estudiantes.Add(estudiantes);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static Estudiantes Buscar(int Id)
        {
            Estudiantes estudiantes = new Estudiantes();
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                estudiantes = context.Estudiantes.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return estudiantes;

        }
        public static bool Editar(Estudiantes estudiantes)
        {
            bool estado = false;

            try
            {
                EstudiantesDb context = new EstudiantesDb();
                context.Entry(estudiantes).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static bool eliminar(int Id)
        {
            Estudiantes estudiantes = null;
            bool estado = false;
            try
            {
                EstudiantesDb context = new EstudiantesDb();
                estudiantes = context.Estudiantes.Find(Id);
                context.Estudiantes.Remove(estudiantes);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;

            }
            return estado;
        }
    }
}
