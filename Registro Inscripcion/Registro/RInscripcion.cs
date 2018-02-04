using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Inscripcion.Consultas;
using Registro_Inscripcion.BLL;
using Registro_Inscripcion.Entidades;

namespace Registro_Inscripciones
{
    public partial class rInscripciones : Form
    {
        public rInscripciones()
        {
            InitializeComponent();
        }
        private void btConsulta_Click(object sender, EventArgs e)
        {
            new cInscripciones().Show();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            if (!CampoVacio())
            {
                if (InscripcionesBLL.Guardar(ObtenerInstancia()))
                    MessageBox.Show("SE ARCHIVO LA INSCRIPCION");
            }
            else
                errpCampoVacio.Clear();

            LimpiarTextBox();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            Inscripciones ins = InscripcionesBLL.Buscar(int.Parse(txInscripcionID.Text));

            if (ins != null)
            {
                txEstudianteID.Text = ins.EstudianteId.ToString();
                dateTimePicker1.Value = DateTime.Parse(ins.Fecha);
                txMonto.Text = ins.Monto.ToString();
                txBalance.Text = ins.Balance.ToString();
                txObservacion.Text = ins.Observaciones;
            }
            else
                MessageBox.Show("Inscripcion invalida");

        }
        //todo: poner numericupdown para los entradas de numeros  

        private bool CampoVacio()
        {
            bool flag = false;

            if (string.IsNullOrWhiteSpace(txEstudianteID.Text)) //todo: poner este tipo de validacion para los vacios
            {
                errpCampoVacio.SetError(txEstudianteID, "El id del estudiante es obligatorio");
                flag = true;
            }

            if (txMonto.Text == "")
            {
                errpCampoVacio.SetError(txMonto, "Campo vacio");
                flag = true;
            }

            if (txBalance.Text == "")
            {
                errpCampoVacio.SetError(txBalance, "Campo vacio");
                flag = true;
            }

            if (txObservacion.Text == "")
            {
                errpCampoVacio.SetError(txObservacion, "Campo vacio");
                flag = true;
            }

            return flag;
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (InscripcionesBLL.Eliminar(int.Parse(txInscripcionID.Text)))
                MessageBox.Show("SE ELIMINO LA INSCRIPCION");

            LimpiarTextBox();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (InscripcionesBLL.Modificar(ObtenerInstancia()))
                MessageBox.Show("SE MODIFICO LA INSCRIPCION");

            LimpiarTextBox();
        }

        private Inscripciones ObtenerInstancia()
        {
            return new Inscripciones(
                0,
                dateTimePicker1.Value.ToString(),
                int.Parse(txEstudianteID.Text),
                float.Parse(txMonto.Text),
                float.Parse(txBalance.Text),
                txObservacion.Text
                );
        }

        private void LimpiarTextBox()
        {
            txInscripcionID.Clear();
            dateTimePicker1.Value = DateTime.Now;
            txEstudianteID.Clear();
            txMonto.Clear();
            txBalance.Clear();
            txObservacion.Clear();
        }

        private void rInscripciones_Load(object sender, EventArgs e)
        {

        }
    }
}