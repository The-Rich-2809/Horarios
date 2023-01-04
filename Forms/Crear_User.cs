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
    public partial class Crear_User : Form
    {
        public Crear_User()
        {
            InitializeComponent();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Gb_Datos.Enabled = true;
            Acciones(false);
            Btn_Agregar.Enabled = true;
            Btn_Cancelar.Enabled = true;
        }

        public void Mostrar()
        {
            Usuario_SQL usuario_SQL = new Usuario_SQL();
            Dgv_Profes.DataSource = usuario_SQL.Mostrar_Usuario();
        }
        public void Inicio()
        {
            Mostrar();
            Gb_Datos.Enabled = false;
            Acciones(true);
            Btn_Agregar.Enabled = false;
            Btn_Mod.Enabled = false;
            Btn_Cancelar.Enabled = false;
            Limpiar();
        }
        public void Acciones(bool i)
        {
            foreach (Control c in this.Gb_Acciones.Controls)
            {
                c.Enabled = i;
            }
        }
        public bool Validar()
        {
            foreach (Control c in this.Gb_Datos.Controls)
            {
                if (c.Text == "")
                {
                    MessageBox.Show("Faltan campos por llenar");
                    return false;
                }
            }
            return true;
        }
        public void Limpiar()
        {
            foreach (Control c in this.Gb_Datos.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }

        private void Crear_User_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                Usuario usuarios = new Usuario();
                Usuario_SQL usuarios_SQL = new Usuario_SQL();

                usuarios.Name = Txt_Nombre.Text;
                usuarios.UserLevel = Txt_Rol.SelectedIndex;
                usuarios.UserName = textBox1.Text;
                usuarios.Password = textBox2.Text;


                if (usuarios_SQL.validarUser(usuarios)) {                     
                    usuarios.Id = usuarios_SQL.generaIdUsuario();
                    if (usuarios_SQL.NewUser(usuarios))
                    {
                        MessageBox.Show(usuarios_SQL.Mensaje);
                        Inicio();
                    }
                    else
                    {
                        MessageBox.Show(usuarios_SQL.Mensaje);
                    }
                }
                else
                {
                    MessageBox.Show(usuarios_SQL.Mensaje);
                }
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            Gb_Datos.Enabled = true;
            Acciones(false);
            Btn_Mod.Enabled = true;
            Btn_Cancelar.Enabled = true;
        }
    }
    
}
