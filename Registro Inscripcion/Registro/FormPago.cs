using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Inscripcion.Entidades;
using Registro_Inscripcion.BLL;

namespace Registro_Incripcion.Registro
{
    public partial class FormPago : Form
    {
        public FormPago()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void GuardarbuttonP_Click(object sender, EventArgs e)
        {
            Pago pago = LlenaClase();
            if (PagosBLL.Guardar(pago))
            {
                VaciarCampos();
                MessageBox.Show("Se guardo el pago con exito!");
            }
            else
            {
                MessageBox.Show("No se puede guardar el pago!");
            }

        }

        private Pago LlenaClase()
        {
            Pago pago = new PagoR();
            float pagoText = float.Parse(PagotextBoxP.Text);
            float montoText = float.Parse(MontotextBox.Text);
            if (pagoText <= montoText)
            {
                pago.IdPago = 0;
                pago.IdEstudiante = Decimal.ToInt32(IdEstudiantesnumericUpDownP.Value);
                pago.Monto = float.Parse(MontotextBox.Text);
                pago.Balance = montoText - pagoText;
                pago.Fecha = FechaTimePickerP.Value;
                pago.Pago = float.Parse(PagotextBoxP.Text);
                pago.Observaciones = ObservacionestextBoxP.Text;
            }
            else
            {
                MessageBox.Show("El pago es mayor que el monto, debe ser igual o menor");
                pago = null;
            }
            return pago;

        }

        private void BuscarbuttonP_Click(object sender, EventArgs e)
        {
            Pago pago = LlenarCampos();




        }

        private void BuscarEbuttonP_Click(object sender, EventArgs e)
        {
            int Id = 0;
            Id = Decimal.ToInt32(IdEstudiantesnumericUpDownP.Value);
            Estudiantes estudiantes = EstudiantesBLL.Buscar(Id);
            if (estudiantes == null)
            {
                MessageBox.Show("No existe el estudiante que busca!");
            }
            else
            {
                Nombrelabel.Text = estudiantes.Nombre;
            }
        }

        private Pago LlenarCampos()
        {
            int Id = 0;
            Id = Decimal.ToInt32(IDnumericUpDownP.Value);
            PagoR pago = PagosBLL.Buscar(Id);
            if (pago == null)
            {
                MessageBox.Show("No se encontro el pago");
            }
            else
            {
                FechaTimePickerP.Value = pago.Fecha.Value;
                IdEstudiantesnumericUpDownP.Value = pago.IdEstudiante;
                MontotextBox.Text = Convert.ToString(pago.Monto);
                PagotextBoxP.Text = Convert.ToString(pago.Pago);
                BalancetextBox.Text = Convert.ToString(pago.Balance);
                ObservacionestextBoxP.Text = pago.Observaciones;
                Estudiantes estudiantes = EstudiantesBLL.Buscar(pago.IdEstudiante);
                Nombrelabel.Text = estudiantes.Nombre;

            }

            return pago;

        }

        private void NuevobuttonP_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }

        public void VaciarCampos()
        {
            FechaTimePickerP.Value = DateTime.Now;
            IdEstudiantesnumericUpDownP.Value = 0;
            MontotextBox.Text = string.Empty;
            PagotextBoxP.Text = string.Empty;
            BalancetextBox.Text = string.Empty;
            ObservacionestextBoxP.Text = string.Empty;
            Nombrelabel.Text = string.Empty;

        }

        private void EliminarbuttonP_Click(object sender, EventArgs e)
        {
            if (PagosBLL.eliminar((int)IDnumericUpDownP.Value))
            {
                VaciarCampos();
                MessageBox.Show("Se elimino correctamente el pago");
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el pago");
            }

        }

        private void FormCreatePago_Load(object sender, EventArgs e)
        {

        }
    }
}
