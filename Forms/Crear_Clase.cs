using Proyecto_Final.Clases;
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

namespace Proyecto_Final.Forms
{
    public partial class Crear_Clase : Form
    {
        public Crear_Clase()
        {
            InitializeComponent();
        }

        private void Crear_Clase_Load(object sender, EventArgs e)
        {
            inicio();
        }
        public void inicio()
        {
            Clases_SQL clases_SQL= new Clases_SQL();
            Dgv_Clases.DataSource =  clases_SQL.Mostrar_Clases();
            foreach(Control c in this.Gb_Datos.Controls)
            {
                c.Enabled = false;
            }
            label4.Enabled = true;
            label5.Enabled = true;
            Cb_Semestre.Enabled = true;
            Cb_Turno.Enabled = true;
            Lbl_Id.Text = "";
        }

        //Eventos para empezar a crear las clases
        private void Txt_Semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(PValidar())
            {
                Comobo_Prof_Materias();
            }
        }
        private void Txt_Turno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PValidar())
            {
                Comobo_Prof_Materias();
            }
        }

        //Llena los Combobox de Profesores y de Materias
        public void Comobo_Prof_Materias()
        {
            Clase clase = new Clase();
            Clases_SQL clases_SQL = new Clases_SQL();

            DataTable TablaProfes = clases_SQL.LlenaComboProfes(Cb_Semestre.Text, Cb_Turno.Text);
            string[] Id = new string[TablaProfes.Rows.Count];
            Cb_Prof.Items.Clear();
            Cb_Prof.Text = "";
            for (int i = 0; i < TablaProfes.Rows.Count; i++)
            {
                Cb_Prof.Items.Add(TablaProfes.Rows[i]["Nombre"].ToString() + " " + TablaProfes.Rows[i]["PApellido"].ToString() + " " + TablaProfes.Rows[i]["SApellido"].ToString());
                Id[i] = TablaProfes.Rows[i]["IdProfe"].ToString();
            }

            DataTable TablaMateria = clases_SQL.LlenaComboMateria(Cb_Semestre.Text);
            Cb_Materia.Items.Clear();
            Cb_Materia.Text = "";
            for (int i = 0; i < TablaMateria.Rows.Count; i++)
            {
                Cb_Materia.Items.Add(TablaMateria.Rows[i]["Nombre"].ToString());
            }
        }
        
        //Valida si hay datos en el semestre y en el turno para despues buscar los profesores y las materias
        public bool PValidar()
        {
            if(Cb_Semestre.Text != "" && Cb_Turno.Text != "")
            {
                foreach(Control c in this.Gb_Datos.Controls)
                {
                    c.Enabled = true;
                }
                foreach(Control c in this.Gb_Horario.Controls)
                {
                    c.Enabled = false;
                    if(c is CheckBox || c is Label)
                    {
                        c.Enabled = true;
                    }
                }
                Lbl_Id.Text = "";
                return true;
            }
            Lbl_Id.Text = "";
            return false;
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
        }

        private void Cb_Prof_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clases_SQL clases_SQL = new Clases_SQL();
            DataTable TablaProfes = clases_SQL.LlenaComboProfes(Cb_Semestre.Text, Cb_Turno.Text);
            Lbl_Id.Text = TablaProfes.Rows[Cb_Prof.SelectedIndex]["IdProfe"].ToString();
        }

        private void ChB_Lunes_CheckedChanged(object sender, EventArgs e)
        {
            if(ChB_Lunes.Checked)
            {
                CB_LunesI.Enabled = true;
                CB_LunesF.Enabled = true;
                LlenarComboDias(CB_LunesI,CB_LunesF);
            }
            else
            {
                CB_LunesI.Enabled = false;
                CB_LunesF.Enabled = false;
            }
        }
        private void ChB_Martes_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ChB_Miercoles_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ChB_Jueves_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void ChB_Viernes_CheckedChanged(object sender, EventArgs e)
        {

        }
        public void LlenarComboDias(ComboBox comboBoxI,ComboBox comboBoxF)
        {
            comboBoxI.Items.Clear();
            comboBoxF.Items.Clear();
            if(Cb_Turno.Text == "Matutino")
            {
                int p = 7, f = 8;
                for (int i = 0; i < 7; i++)
                {
                    comboBoxI.Items.Add(p+ ":00");
                    comboBoxF.Items.Add(f + ":00");
                    p++;
                    f++;
                }
            }
            if (Cb_Turno.Text == "Vespertino")
            {
                int p = 15, f = 16;
                for (int i = 0; i < 7; i++)
                {
                    comboBoxI.Items.Add(p + ":00");
                    comboBoxF.Items.Add(f + ":00");
                    p++;
                    f++;
                }
            }
        }
    }
}
