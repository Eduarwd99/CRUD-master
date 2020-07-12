using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC
{
    public static class DatoPersonasDAO
    {
        public static int creacion(DatosPersonas datosPersonas)
        {
            // 1) Configurar la  conexion de datos con una fuente de datos 
            string cadenaConexion = "server=DESKTOP-9VT6L6J; database=TI2020; integrated security = true";
            // Definir un objeto tipo conexion 
            SqlConnection conn = new SqlConnection(cadenaConexion);
            
            // 2) Definir la opercion a realizar en el motor BDD
            // Escribir sentecia SQL
            string sql = "insert into Datos_Persona(Cedula,Apellidos,Nombres,Sexo," + "FechaNacimiento,Correo,Estatura_Cm,Peso) values(@Cedula,@Apellidos,@Nombres,@Sexo,@FechaNacimiento,@Correo,@Estatura_Cm,@Peso)";
            // Definir un comando para ejecutar esa sentencia sql (operacion a realizar)
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.CommandType = System.Data.CommandType.Text; // Valor por defecto 
            comando.Parameters.AddWithValue("@Cedula", datosPersonas.Cedula);
            comando.Parameters.AddWithValue("@Apellidos", datosPersonas.Apellidos);
            comando.Parameters.AddWithValue("@Nombres", datosPersonas.Nombres);
            comando.Parameters.AddWithValue("@Sexo", datosPersonas.Sexo);
            comando.Parameters.AddWithValue("@FechaNacimiento", datosPersonas.FechaNacimiento.Date);
            comando.Parameters.AddWithValue("@Correo", datosPersonas.Correo);
            comando.Parameters.AddWithValue("@Estatura_Cm", datosPersonas.Estatura);
            comando.Parameters.AddWithValue("@Peso", datosPersonas.Peso);
            
            // 3) Se habre la conexion y se ejecuta el comando 
            conn.Open();
            int x = comando.ExecuteNonQuery(); // Ejecutamos el comando
            
            // 4) Cerrar la conexion 
            conn.Close();
            return x;
        }
    }
}
