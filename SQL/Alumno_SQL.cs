using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.SQL
{
    internal class Alumno_SQL
    {
        public string Mensaje { get; set; }
        public DataTable Mostrar_Horario(string semestre, string turno)
        {
            DataTable tablaProductos = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select Grupo,Materia,Profesor,Lunes,Martes,Miercoles,Jueves,Viernes from Clases where Turno = @Turno and Semestre = @Semestre";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Turno", turno);
                    cmdSelect.Parameters.AddWithValue("@Semestre", semestre);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProductos);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return tablaProductos;
            }
        }

        public DataTable LlenaComboMaterias(string semestre)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {

                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaRoles = new DataTable();
                string sentencia = "Select Nombre from Materias Where Semestre = @Semestre";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Semestre", semestre);
                    AdapterRoles.SelectCommand = cmdSelect;
                    conexion.Open();
                    AdapterRoles.Fill(TablaRoles);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return TablaRoles;
            }
        }
        public string[] LlenaComboProfes(string semestre)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                string[] arra = new string[0];
                SqlCommand cmdSelect;
                SqlDataAdapter AdapterRoles = new SqlDataAdapter();
                DataTable TablaRoles = new DataTable();
                string sentencia = "Select Nombre,PApellido,SApellido from Profesores Where Semestre = @Semestre";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Semestre", semestre);
                    AdapterRoles.SelectCommand = cmdSelect;
                    conexion.Open();
                    AdapterRoles.Fill(TablaRoles);
                    string[] array = new string[TablaRoles.Rows.Count];

                    for (int i = 0; i <= TablaRoles.Rows.Count - 1; i++)
                    {
                        array[i] = TablaRoles.Rows[i]["Nombre"].ToString() + " " + TablaRoles.Rows[i]["PApellido"].ToString() + " " + TablaRoles.Rows[i]["SApellido"].ToString();
                    }
                    return array;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                return arra;
            }
        }
    }
}
