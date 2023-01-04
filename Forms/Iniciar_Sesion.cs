using Proyecto_Final.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class Iniciar_Sesion : Form
    {
        public static bool datosCorrectos;
        public Iniciar_Sesion()
        {
            
            InitializeComponent();
        }

        private void Btn_Iniciar_Click(object sender, EventArgs e)
        {
            bool ing = Ingresar();
            if (ing == true && datosCorrectos == true)
            {
                this.Visible = false;
            }
            
        }
        private void Btn_Iniciar_KeyPress(object sender, KeyPressEventArgs e)
        {
            Ingresar();
        }
        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            Iniciar_Sesion iniciar_Sesion = this;
            iniciar_Sesion.Visible = false;
            Alumno alumno = new Alumno();
            alumno.ShowDialog();
            
            
        }

        public bool Ingresar()
        {
            Iniciar iniciar = new Iniciar();
            if (Txt_User.Text == "" || Txt_Pass.Text == "")
            {
                MessageBox.Show("Campos en blanco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            else
            {
                if (iniciar.In_Sesion(Txt_User.Text, Txt_Pass.Text))
                {
                    Txt_User.Text = "";
                    Txt_Pass.Text = "";
                }
                return true;
            }
        }

        private void Txt_Pass_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
