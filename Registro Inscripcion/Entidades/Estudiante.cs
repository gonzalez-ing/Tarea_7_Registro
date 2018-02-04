using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_Inscripcion.Entidades
{

    public class Estudiantes
    {
        [Key]
        public int EstudianteID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Matricula { get; set; }
        public string NomCarrera { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public Estudiantes()
        {
            this.EstudianteID = 0;
            this.Nombres = String.Empty;
            this.Apellidos = String.Empty;
            this.Matricula = String.Empty;
            this.NomCarrera = String.Empty;
            this.Edad = 0;
            this.Direccion = String.Empty;
            this.Telefono = String.Empty;
        }

        public Estudiantes(int EstudianteId, string Nombres, string Apellidos, string NombreCarrera, string Matricula, int Edad, string Direccion, string Telefono)
        {
            this.EstudianteID = EstudianteId;
            this.Apellidos = Apellidos;
            this.Matricula = Matricula;
            this.NomCarrera = NombreCarrera;
            this.Edad = Edad;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
        }

    }
}
