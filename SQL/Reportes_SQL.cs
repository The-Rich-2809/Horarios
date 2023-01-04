using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.Clases;

namespace Proyecto_Final.SQL
{
    internal class Reportes_SQL
    {
        public string Mensaje { get; set; }
        public DataTable Mostrar_Reportes()
        {
            DataTable tablaReportes = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Reportes ";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaReportes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tablaReportes;
            }
        }
        public DataTable Llenar_Grupo(string turno)
        {
            DataTable tablaClases = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Clases where Turno = @Turno";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);

                    adapter.SelectCommand = cmdSelect;
                    cmdSelect.Parameters.AddWithValue("@Turno", turno);
                    conexion.Open();
                    adapter.Fill(tablaClases);
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }

                return tablaClases;
            }
        }
        public DataTable Llenar_Materia(string grupo)
        {
            DataTable tablaClases = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Clases where Grupo = @Grupo";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    cmdSelect.Parameters.AddWithValue("@Grupo", grupo);
                    conexion.Open();
                    adapter.Fill(tablaClases);
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }

                return tablaClases;
            }
        }
        public bool New_Reporte(Reportes reportes)
        {
            bool Operacion = false;

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                int resultado = 0;
                string SentenciaSQL = @"Insert Into Reportes Values (@Id,@Grupo,@Turno,@Materia,@DiaReporte,@Reporte)";
                Consulta = new SqlCommand(SentenciaSQL, conexion);

                Consulta.Parameters.AddWithValue("@Id", reportes.IdReporte);
                Consulta.Parameters.AddWithValue("@Grupo", reportes.Grupo);
                Consulta.Parameters.AddWithValue("@Turno", reportes.Turno);
                Consulta.Parameters.AddWithValue("@Materia", reportes.Materia);
                Consulta.Parameters.AddWithValue("@DiaReporte", reportes.DiaReporte);
                Consulta.Parameters.AddWithValue("@Reporte", reportes.Reporte);
                try
                {
                    conexion.Open();
                    resultado = Consulta.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Reporte registrado correctamente";
                        Operacion = true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return Operacion;
        }
        public bool Eliminar_Reporte(string i)
        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                int filasafectadas;
                string sentencia = @"delete from Reportes where IdReporte = @id";
                cmdCreate = new SqlCommand(sentencia, conexion);
                cmdCreate.Parameters.AddWithValue("@id", Convert.ToString(i));
                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Reporte elimidado exitosamente";
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
            return false;
        }

        public int generaIdUsuario()
        {
            object tmp;
            int IdReporte = 0;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                string sentencia = "select max(IdReporte) from Reportes";
                try
                {
                    cmdCreate = new SqlCommand(sentencia, conexion);
                    conexion.Open();
                    tmp = cmdCreate.ExecuteScalar();
                    if (tmp.Equals(DBNull.Value))
                    {
                        IdReporte = 1;
                    }
                    else
                    {
                        IdReporte = Convert.ToInt32(tmp);
                        IdReporte++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return IdReporte;
        }

    }
}
