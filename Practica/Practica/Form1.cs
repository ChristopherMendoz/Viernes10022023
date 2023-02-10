using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void clearFind()
        {
            txtNombre.Text = String.Empty;
            txtEdad.Text = String.Empty;
            cboSexoEs.Text = String.Empty;
            cboNota.Text = String.Empty;
            txtAsistencia.Text= String.Empty;

            txtNombre.Focus();
        }
        public void clearFind2()
        {
            txtNombreDoc.Text = String.Empty;
            txtEdadDoc.Text = String.Empty;
            cboSexDoc.Text = String.Empty;
            cboAsignat.Text = String.Empty;

            txtNombreDoc.Focus();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtEdad.Text == "" || cboSexoEs.Text == "" || cboNota.Text == "")
            {
                MessageBox.Show("Verifique los campos en Blanco...");
            }
            else
            {
                string nombrEs, SexEs, NotaEs;
                int EdadEs=0;
                int asistencia=10 ;
                nombrEs = txtNombre.Text;
                EdadEs = int.Parse(txtEdad.Text);
                SexEs = cboSexoEs.Text;
                NotaEs = cboNota.Text;
                asistencia= int.Parse(txtAsistencia.Text);
                

                string[] datos = new string[6];

                datos[0] = nombrEs;
                datos[1] = EdadEs.ToString();
                datos[2] = SexEs;
                datos[3] = NotaEs;
                datos[4] = asistencia.ToString();
                if (asistencia < 5)
                {
                    datos[5]=("Pierde Asignatura");
                }
                else
                {
                    datos[5] = ("Asignatura Disponible");
                }

                dataGridView1.Rows.Add(datos);
                clearFind();
            }
        }

        private void btnDatoPrf_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            panel2.Visible=false;
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            if (txtNombreDoc.Text == "" || txtEdadDoc.Text == "" || cboSexDoc.Text == "" || cboAsignat.Text == "")
            {
                MessageBox.Show("Verifique los campos en Blanco...");
            }
            else
            {
                string nombrDoc, SexDoc, Asignatura;
                string EdadDoc;
                nombrDoc = txtNombreDoc.Text;
                EdadDoc = txtEdadDoc.Text;
                SexDoc = cboSexDoc.Text;
                Asignatura = cboAsignat.Text;

                string[] dat = new string[4];

                dat[0] = nombrDoc;
                dat[1] = EdadDoc;
                dat[2] = SexDoc;
                dat[3] = Asignatura;

                dataGridView2.Rows.Add(dat);
                clearFind2();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            clearFind();
        }
    }
}
