using Microsoft.Win32;
using Proyecto_Final.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Final.Forms
{
    public partial class Alumno : Form
    {
        public Alumno()
        {
            InitializeComponent();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            Cb_Filtros.Enabled = false;
            Gb_Filtros.Enabled = false;
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            if((Rb_Matutino.Checked || Rb_Vespertino.Checked) && Cb_Semestre.Text != "")
            {
                string turno = "";
                string semestre;
                semestre = Cb_Semestre.Text;
                if (Rb_Matutino.Checked)
                {
                    turno = Rb_Matutino.Text;
                }
                
                if (Rb_Vespertino.Checked)
                {
                    turno = Rb_Vespertino.Text;
                }

                Alumno_SQL alumno_SQL = new Alumno_SQL();
                Dgv_Horario.DataSource = alumno_SQL.Mostrar_Horario(semestre, turno);
                Dgv_Horario.AutoSize = true;
                Cb_Filtros.Enabled = true;
            }
            else
            {
                MessageBox.Show("Faltan campos a llenar");
            }
        }

        private void Filtros_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Filtros.Checked)
            {
                Gb_Filtros.Enabled = true;
                foreach (Control c in this.Gb_Filtros.Controls)
                {
                    if (c is ComboBox)
                    {
                        c.Enabled = false;
                    }
                }

                DataTable data;
                Alumno_SQL alumno_SQL = new Alumno_SQL();

                data = alumno_SQL.LlenaComboMaterias(Cb_Semestre.Text);
                Ctxt_Materia.DataSource = data;
                Ctxt_Materia.DisplayMember = "Nombre";
                Ctxt_Materia.Text = "";

                string[] prof = alumno_SQL.LlenaComboProfes(Cb_Semestre.Text);
                
                for(int i = 0; i <= prof.Length-1; i++)
                {
                    Ctxt_Profesor.Items.Add(prof[i]);
                }
            }   

            else
            {
                Gb_Filtros.Enabled = false;
            }
        }
        private void Cb_Grupo_CheckedChanged(object sender, EventArgs e)
        {
            if(Cb_Grupo.Checked)
            {
                Ctxt_Grupo.Enabled = true;
            }
            else
            {
                Ctxt_Grupo.Enabled = false;
            }
        }
        private void Cb_Materia_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Materia.Checked)
            {
                Ctxt_Materia.Enabled = true;
            }
            else
            {
                Ctxt_Materia.Enabled = false;
            }
        }
        private void Cb_Profesor_CheckedChanged(object sender, EventArgs e)
        {
            if (Cb_Profesor.Checked)
            {
                Ctxt_Profesor.Enabled = true;
            }
            else
            {
                Ctxt_Profesor.Enabled = false;
            }
        }
    }
}
