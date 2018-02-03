using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Registro_Inscripcion.DAL;
using Registro_Inscripcion.Entidades;

namespace Registro_Inscripcion.Entidades
{
    public class Inscripciones
    {

        [Key]
        public int InscripcionID { get; set; }
        public string Fecha { get; set; }
        public DateTime FechaD { get; set; }
        public int EstudianteId { get; set; }
        public float Monto { get; set; }
        public float Balance { get; set; }
        public string Observaciones { get; set; }

        public Inscripciones()
        {
            this.InscripcionID = 0;
            this.Fecha = "";
            this.EstudianteId = 0;
            this.Monto = 0;
            this.Balance = 0;
            this.Observaciones = "";
        }

        public Inscripciones(int InscripcionID, string Fecha, int EstudianteId, float Monto, float Balance, string Observaciones)
        {
            this.InscripcionID = InscripcionID;
            this.Fecha = Fecha;
            FechaD = DateTime.Parse(Fecha);
            this.EstudianteId = EstudianteId;
            this.Monto = Monto;
            this.Balance = Balance;
            this.Observaciones = Observaciones;
        }
    }
}
