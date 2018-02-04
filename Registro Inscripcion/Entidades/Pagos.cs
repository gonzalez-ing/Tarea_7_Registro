using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroPago.Entidades
{
    public class Pagos
    {
        [Key]
        public int IdPago { get; set; }
        public int IdEstudiante { get; set; }
        public float Monto { get; set; }
        public float Balance { get; set; }
        public float Pago { get; set; }
        public string Observaciones { get; set; }
        public DateTime? Fecha { get; set; }


        public Pagos()
        {
            this.IdPago = 0;
            this.IdEstudiante = 0;
            this.Monto = 0;
            this.Balance = 0;
            this.Pago = 0;
            this.Fecha = null;
            this.Observaciones = string.Empty;

        }

        public Pagos(int idPago, int idEstudiante, float monto, float balance, DateTime fecha, string observaciones, float pago)
        {
            this.IdPago = idPago;
            this.IdEstudiante = idEstudiante;
            this.Monto = monto;
            this.Balance = balance;
            this.Pago = pago;
            this.Fecha = fecha;
            this.Observaciones = observaciones;

        }
    }
}
