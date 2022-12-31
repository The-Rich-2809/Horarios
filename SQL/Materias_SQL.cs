using Proyecto_Final.Clases;
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
    internal class Materias_SQL
    {
        public string Mensaje { get; set; }
        public DataTable Mostrar_Materias()
        {
            DataTable tablaMaterias = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Materias ";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaMaterias);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tablaMaterias;
            }
        }

        public bool New_Materias(Materias materias)
        {
            bool Operacion = false;

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                int resultado = 0;
                string SentenciaSQL = @"Insert Into Materias Values (@Id,@Nombre,@Sem)";
                Consulta = new SqlCommand(SentenciaSQL, conexion);

                Consulta.Parameters.AddWithValue("@Id", materias.Id);
                Consulta.Parameters.AddWithValue("@Nombre", materias.Nombre);
                Consulta.Parameters.AddWithValue("@Sem", materias.Semestre);
               
                try
                {
                    conexion.Open();
                    resultado = Consulta.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Materia registrada correctamente";
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
        public bool Eliminar_Materia(int i)

        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                int filasafectadas;
                string sentencia = @"delete from Materia where IdMateria = @id";
                cmdCreate = new SqlCommand(sentencia, conexion);
                cmdCreate.Parameters.AddWithValue("@id",i);
                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Materia eliminada exitosamente";
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
        public int generaIdMateria(int Id)
        {
            int i = 0;
            while (i == 0)
            {
                DataTable tablaMateria = new DataTable();
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    SqlCommand cmdSelect;
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    string sentencia = @"Select * from Materias where IdMateria = @Id";
                    try
                    {
                        cmdSelect = new SqlCommand(sentencia, conexion);
                        cmdSelect.Parameters.AddWithValue("@Id", Id);
                        adapter.SelectCommand = cmdSelect;
                        conexion.Open();
                        adapter.Fill(tablaMateria);

                        if (tablaMateria.Rows.Count > 0)
                        {
                            Id++;
                        }
                        else
                        {
                            i = 1;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            return Id;
        }
        public bool validarMateria(Materias materias)
        {
            DataTable tablaProf = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = @"Select * from Materias where Nombre = @Nombre";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Nombre", materias.Nombre);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProf);

                    if (tablaProf.Rows.Count > 0)
                    {
                        Mensaje = "Esta materia ya esta registrada";
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
    }
}

