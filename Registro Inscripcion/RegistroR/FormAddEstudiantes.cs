using Registro_Inscripcion.BLL;
using Registro_Inscripcion.Entidades;
using System;
using System.Windows.Forms;


namespace Registro_Inscripcion.Registro
{
    public partial class FormAddEstudiantes : Form
    {
        public FormAddEstudiantes()
        {
            InitializeComponent();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiantes estudiantes = llenaraClase();
            if (EstudiantesBLL.Guardar(estudiantes))
            {
                VaciarCampos();
                MessageBox.Show("se guardo correctamente");
            }


        }

        private Estudiantes llenaraClase()
        {
            Estudiantes estudiantes = new Estudiantes();
            estudiantes.IdEstudiante = 0;
            estudiantes.Nombres = NombrestextBox.Text;
            estudiantes.Direccion = DirecciontextBox.Text;
            estudiantes.Carrerra = CarreratextBox.Text;
            estudiantes.FechaN = FechaNdateTimePicker.Value;

            return estudiantes;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id = 0;
            id = Decimal.ToInt32(IDnumericUpDown.Value);
            LlenarCampo(id);
        }

        private void LlenarCampo(int id)
        {
            Estudiantes estudiantes = new Estudiantes();

            estudiantes = EstudiantesBLL.Buscar(id);
            if (estudiantes == null)
            {
                MessageBox.Show("El id estudiante que esta buscando no existe");
            }
            else
            {

                NombretextBox.Text = estudiantes.Nombres;
                DirecciontextBox.Text = estudiantes.Direccion;
                CarreratextBox.Text = estudiantes.Carrerra;
                FechaNdateTimePicker.Value = estudiantes.FechaN.Value;
            }



        }

        private void IDnumericUpDown_ValueChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            VaciarCampos();
        }
        public void VaciarCampos()
        {
            NombretextBox.Text = string.Empty;
            DirecciontextBox.Text = string.Empty;
            CarreratextBox.Text = string.Empty;
            FechaNdateTimePicker.Text = string.Empty;
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Editarbutton_Click(object sender, EventArgs e)
        {

            int id = 0;
            id = Decimal.ToInt32(IDnumericUpDown.Value);
            Estudiantes estudiantes = EstudiantesBLL.Buscar(id);

            try
            {
                estudiantes.Nombres = NombretextBox.Text;
                estudiantes.Direccion = DirecciontextBox.Text;
                estudiantes.Carrera = CarreratextBox.Text;
                estudiantes.FechaN = FechaNdateTimePicker.Value;
                if (EstudiantesBLL.Editar(estudiantes))
                {
                    VaciarCampos();
                    MessageBox.Show("Se edito con exito el estudiante " + estudiantes.Nombre);
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el estudiante");
                }

            }
            catch (Exception)
            {
                throw;
            }

        }

        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            if (EstudiantesBLL.eliminar((int)IDnumericUpDown.Value))
            {
                VaciarCampos();
                MessageBox.Show("Se borro con exito el estudiante");
            }
            else
            {
                MessageBox.Show("Problema al borrar los datos");
            }
        }
    }
}