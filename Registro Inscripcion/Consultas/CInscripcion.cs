using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_Inscripcion.BLL;
using Registro_Inscripcion.Entidades;

namespace Registro_Inscripcion.Consultas
{
    public partial class CInscripciones : Form
    {
        public CInscripciones()
        {
            InitializeComponent();
            subCombobox.Visible = false;
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            Expression<Func<Inscripciones, bool>> filter;
            int z = 0;
            int.TryParse(txValor.Text, out z);

            switch (filterCombobox.SelectedIndex)
            {
                case 0:  //todos               
                    filter = (i => i.InscripcionID == z);
                    break;

                case 1:
                    if (subCombobox.SelectedIndex == 0)
                        dataGridView1.DataSource = InscripcionesBLL.GetList(
                            i => i.FechaD.Day == z);

                    if (subCombobox.SelectedIndex == 1)
                        dataGridView1.DataSource = InscripcionesBLL.GetList(
                            i => i.FechaD.Month == z);

                    if (subCombobox.SelectedIndex == 2)
                        dataGridView1.DataSource = InscripcionesBLL.GetList(
                            i => i.FechaD.Year == z);
                    break;

                case 2:
                    dataGridView1.DataSource = InscripcionesBLL.GetList(i => i.EstudianteId == z);
                    break;


                case 3:
                    dataGridView1.DataSource = InscripcionesBLL.GetList(i => i.Monto == z);
                    break;

                case 4:
                    dataGridView1.DataSource = InscripcionesBLL.GetList(i => i.Balance == z);
                    break;

                case 5:
                    dataGridView1.DataSource = InscripcionesBLL.GetList(i => i.Observaciones.Contains(txValor.Text));
                    break;
            }

            dataGridView1.DataSource = InscripcionesBLL.GetList(filter);
        }

        private void filterCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (filterCombobox.SelectedIndex == 1)
                subCombobox.Visible = true;
            else
                subCombobox.Visible = false;
        }

        private void cInscripciones_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CInscripciones_Load_1(object sender, EventArgs e)
        {

        }

        private void CInscripciones_Load_2(object sender, EventArgs e)
        {

        }
    }
}