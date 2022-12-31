using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace Proyecto_Final.SQL
{
    internal class Clases_SQL
    {
        public string Mensaje { get; set; }
        public DataTable Mostrar_Clases()
        {
            DataTable tablaClases = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Clases ";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaClases);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tablaClases;
            }
        }
        public DataTable LlenaComboProfes(string Sem,string Turno)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaProfes = new DataTable();
               
                string sentencia = "select IdProfe,Nombre,PApellido,SApellido from Profesores where Semestre = @Sem and Turno = @Turno";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Sem", Sem);
                    cmdSelect.Parameters.AddWithValue("@Turno", Turno);
                    AdapterRoles.SelectCommand = cmdSelect;
                    conexion.Open();
                    AdapterRoles.Fill(TablaProfes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return TablaProfes;
            }
        }
        public DataTable LlenaComboMateria(string Id)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaMaterias = new DataTable();

                string sentencia = "select Nombre from Materias where Semestre = @Id";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Id", Id);
                    AdapterRoles.SelectCommand = cmdSelect;
                    conexion.Open();
                    AdapterRoles.Fill(TablaMaterias);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return TablaMaterias;
            }
        }
    }
}
