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
            clase.Id = Id;

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
    }
}
