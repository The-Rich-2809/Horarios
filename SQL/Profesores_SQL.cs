using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final.Clases;
using Proyecto_Final.Forms;
using System.Diagnostics.Contracts;

namespace Proyecto_Final.SQL
{
    internal class Profesores_SQL
    {
        public string Mensaje { get; set; }
        public DataTable Mostrar_Profesores()
        {
            DataTable tablaProfes = new DataTable();

            Mensaje = String.Empty;
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = "select * from Profesores ";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProfes);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                return tablaProfes;
            }
        }

        public bool New_Profesores(Profesores profesores)
        {
            bool Operacion = false;

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand Consulta;
                int resultado = 0;
                string SentenciaSQL = @"Insert Into Profesores Values (@Id,@Nombre,@PA,@SA,@Sem,@Tur)";
                Consulta = new SqlCommand(SentenciaSQL, conexion);

                Consulta.Parameters.AddWithValue("@Id", profesores.Id);
                Consulta.Parameters.AddWithValue("@Nombre", profesores.Nombre);
                Consulta.Parameters.AddWithValue("@PA", profesores.PApellido);
                Consulta.Parameters.AddWithValue("@SA", profesores.SApellido);
                Consulta.Parameters.AddWithValue("@Sem", profesores.Semestre);
                Consulta.Parameters.AddWithValue("@Tur", profesores.Turno);
                try
                {
                    conexion.Open();
                    resultado = Consulta.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        Mensaje = "Profesor registrado correctamente";
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
        public bool Eliminar_Prof(int i)

        {
            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdCreate;
                int filasafectadas;
                string sentencia = @"delete from Profesores where IdProfe = @id";
                cmdCreate = new SqlCommand(sentencia, conexion);
                cmdCreate.Parameters.AddWithValue("@id", Convert.ToString(i));
                try
                {
                    conexion.Open();
                    filasafectadas = cmdCreate.ExecuteNonQuery();
                    if (filasafectadas > 0)
                    {
                        Mensaje = "Usuario elimidado exitosamente";
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
        public int generaIdProf(int Id)
        {
            int i = 0;
            while (i == 0)
            {
                DataTable tablaProf = new DataTable();
                using (SqlConnection conexion = Conexion.Conectar())
                {
                    SqlCommand cmdSelect;
                    SqlDataAdapter adapter = new SqlDataAdapter();

                    string sentencia = @"Select * from Profesores where IdProfe = @Id";
                    try
                    {
                        cmdSelect = new SqlCommand(sentencia, conexion);
                        cmdSelect.Parameters.AddWithValue("@Id", Id);
                        adapter.SelectCommand = cmdSelect;
                        conexion.Open();
                        adapter.Fill(tablaProf);

                        if (tablaProf.Rows.Count > 0)
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
        public bool validarProf(Profesores profesores)
        {
            DataTable tablaProf = new DataTable();

            using (SqlConnection conexion = Conexion.Conectar())
            {
                SqlCommand cmdSelect;
                SqlDataAdapter adapter = new SqlDataAdapter();

                string sentencia = @"Select * from Profesores where Nombre = @Nombre and PApellido = @PA and SApellido = @SA and Turno = @Turno and Semestre = @Sem";
                try
                {
                    cmdSelect = new SqlCommand(sentencia, conexion);
                    cmdSelect.Parameters.AddWithValue("@Nombre",profesores.Nombre );
                    cmdSelect.Parameters.AddWithValue("@PA", profesores.PApellido);
                    cmdSelect.Parameters.AddWithValue("@SA", profesores.SApellido);
                    cmdSelect.Parameters.AddWithValue("@Turno", profesores.Turno);
                    cmdSelect.Parameters.AddWithValue("@Sem", profesores.Semestre);
                    adapter.SelectCommand = cmdSelect;
                    conexion.Open();
                    adapter.Fill(tablaProf);

                    if (tablaProf.Rows.Count > 0)
                    {
                        Mensaje = "Este profesor ya esta registrado";
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
