using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TIC_MATERIAS
{
    public static class DatosMateriasDAO
    {
        private static String cadenaConexion = @"server=PC; database=TI2020; integrated security = true";
        public static int create(DatosMaterias materias)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "insert into Materias(Codigo,NombreMateria,Creditos,Carrera,Nivel) values(@Codigo,@NombreMateria,@Creditos,@Carrera,@Nivel)";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.CommandType = System.Data.CommandType.Text; 
            comando.Parameters.AddWithValue("@Codigo", materias.Codigo);
            comando.Parameters.AddWithValue("@NombreMateria", materias.NombreMateria);
            comando.Parameters.AddWithValue("@Creditos", materias.Creditos);
            comando.Parameters.AddWithValue("@Carrera", materias.Carrera);
            comando.Parameters.AddWithValue("@Nivel", materias.Nivel);
            conn.Open();
            int x = comando.ExecuteNonQuery(); 
            conn.Close();
            return x;
        }
        public static int delete(String codigo)
        {
            int y = 0;
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "delete from Materias where Codigo = '" + codigo + "'";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.CommandType = System.Data.CommandType.Text;
            conn.Open();
            if (comando.ExecuteNonQuery() == 1)
                y = 1;
            conn.Close();
            return y;
        }
        public static int update(DatosMaterias materias)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "update Materias set NombreMateria=@NombreMateria, Creditos=@Creditos, Carrera=@Carrera, Nivel=@Nivel where Codigo=@Codigo";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@Codigo", materias.Codigo);
            comando.Parameters.AddWithValue("@NombreMateria", materias.NombreMateria);
            comando.Parameters.AddWithValue("@Creditos", materias.Creditos);
            comando.Parameters.AddWithValue("@Carrera", materias.Carrera);
            comando.Parameters.AddWithValue("@Nivel", materias.Nivel);
            conn.Open();
            int z = comando.ExecuteNonQuery();
            conn.Close();
            return z;
        }
        public static DatosMaterias getMaterias(String codigo)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select Codigo, NombreMateria, Creditos, Carrera, Nivel from Materias where Codigo = '" + codigo + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@Codigo", codigo);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            DatosMaterias materia = new DatosMaterias();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    materia.Codigo = fila["Codigo"].ToString();
                    materia.NombreMateria = fila["NombreMateria"].ToString();
                    materia.Creditos = int.Parse(fila["Creditos"].ToString());
                    materia.Carrera = fila["Carrera"].ToString();
                    materia.Nivel = int.Parse(fila["Nivel"].ToString());
                    break;
                }
            }
            return materia;
        }
        public static DataTable getMateriasBusqueda()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select Codigo, '[' + Codigo + ']' + ' ' + NombreMateria [Materia_Cod] from Materias order by Codigo, NombreMateria";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static DataTable getAll()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select Codigo, NombreMateria, Creditos, Carrera, Nivel from Materias order by Codigo, NombreMateria";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static Boolean existeCodigo(String codigo)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select Codigo from Materias where Codigo = @Codigo";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@Codigo", codigo);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            Boolean existe = false;
            if (dt.Rows.Count > 0)
                existe = true;
            return existe;
        }
    }
}