using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TIC
{
    public static class DatoPersonasDAO
    {
        private static String cadenaConexion = @"server=PC; database=TI2020; user id=Eduardo.Arizala; password=1234";
        public static int creacion(DatosPersonas datosPersonas)
        {
            // 1) Configurar la  conexion de datos con una fuente de datos 
            //string cadenaConexion = @"server=DESKTOP-9VT6L6J; database=TI2020; integrated security = true";
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
        public static int delete(String cedulaBorrar)
        {
            //Crear el metodo borrar usando como guia el metodo usar
            //La sentencia sql es la siguiente:
            //"delete from NombreTable where campo=@campo
            //Definir la interfaz de usuario para probar este metodo
            //txt ingresa la cedula a borrar y luego se borra  

            int y = 0;
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "delete from Datos_Persona " + "where Cedula = '" + cedulaBorrar + "'";
            SqlCommand comando = new SqlCommand(sql, conn);
            comando.CommandType = System.Data.CommandType.Text;

            conn.Open();
            if (comando.ExecuteNonQuery() == 1)
                y = 1;//comando.ExecuteNonQuery(); // Se borro
            conn.Close();
            return y;
        }
        public static int update(DatosPersonas datosPersonas)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);            
            string sql = "update Datos_Persona " + "set Apellidos=@Apellidos, Nombres=@Nombres, Sexo=@Sexo, FechaNacimiento=@FechaNacimiento, Correo=@Correo, Estatura_Cm=@Estatura_Cm, Peso=@Peso " + "where Cedula=@Cedula";
            SqlCommand comando = new SqlCommand(sql, conn);

            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@Cedula", datosPersonas.Cedula);
            comando.Parameters.AddWithValue("@Apellidos", datosPersonas.Apellidos);
            comando.Parameters.AddWithValue("@Nombres", datosPersonas.Nombres);
            comando.Parameters.AddWithValue("@Sexo", datosPersonas.Sexo);
            comando.Parameters.AddWithValue("@FechaNacimiento", datosPersonas.FechaNacimiento.Date);
            comando.Parameters.AddWithValue("@Correo", datosPersonas.Correo);
            comando.Parameters.AddWithValue("@Estatura_Cm", datosPersonas.Estatura);
            comando.Parameters.AddWithValue("@Peso", datosPersonas.Peso);

            conn.Open();
            int z = comando.ExecuteNonQuery(); 
            conn.Close();
            return z;
        }
        public static DataTable getAll()
        {
            //1. Definir y configurar conexion
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //2. Definir y configurar la operacion a realizar en el motor de BDD
            //Escribir sentecia sql

            string sql = "select Cedula, Apellidos, Nombres, Sexo, FechaNacimiento, Correo, Estatura_Cm, Peso " + "from Datos_Persona " + "order by Apellidos, Nombres";
            //string sql = "select Cedula, upper(Apellidos + ' ' + Nombres)[Nombre Completo], " + "Sexo, FechaNacimiento, Correo, Estatura_Cm, Peso " + "from Datos_Persona " + "order by Apellidos, Nombres";
            //Linea del Profe string sql = "select cedula Cédula,upper(Apellidos + ' ' + Nombres) [Nombre Completo],sexo Género, " + "FechaNacimiento, Correo, estaturacm [Estatura en cm]" + "from DatosPersonas " +   "order by apellidos, nombres";

            //Definir un adaptador de datos (puente que permite pasar datos del daatatable a la BDD)
            //El adaptador abre y cierra la sesion al sacar datos
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);

            //3. Recuperamos los datos
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static DataTable getPersonasEdad()
        {
            //1. Definir y configurar conexion
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //2. Definir y configurar la operacion a realizar en el motor de BDD
            //Escribir sentecia sql

            /*  
                select cedula Cédula
                ,upper(Apellidos + ' ' + Nombres) + '(' + ltrim(str(DATEDIFF(year, FechaNacimiento, getDate()))) + ' años)'[Nombre Completo]
                from DatosPersonas
                order by apellidos, nombres
            */
            string sql = "select Cedula, upper(Apellidos + ' ' + Nombres) + ' (' + ltrim(str(DATEDIFF(year, FechaNacimiento, getDate()))) + ' años)' [Nombre Completo] " + "from Datos_Persona " + "order by Apellidos, Nombres";
            
            //Definir un adaptador de datos (puente que permite pasar datos del daatatable a la BDD)
            //El adaptador abre y cierra la sesion al sacar datos
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);

            //3. Recuperamos los datos
            DataTable dt = new DataTable();
            ad.Fill(dt);
            return dt;
        }
        public static Boolean existeCedula(String scedula)
        {
            //1. Definir y configurar conexion
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //2. Definir y configurar la operacion a realizar en el motor de BDD
            //Escribir sentecia sql
            string sql = "select Cedula " + "from Datos_Persona " + "where Cedula = @Cedula";
            //Definir un adaptador de datos (puente que permite pasar datos del daatatable a la BDD)
            //El adaptador abre y cierra la sesion al sacar datos
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@Cedula", scedula);
            
            //3. Recuperamos los datos
            DataTable dt = new DataTable();
            ad.Fill(dt);
            Boolean existe = false;
            if (dt.Rows.Count > 0) //Si existen filas
                existe = true;
            return existe;
        }
        public static Boolean verificarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }
        public static DatosPersonas getPersona(String Scedula) //TAREA MODIFICAR
        {
            //1. Definir y configurar conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //2. Definir y configurar la operación a realizar en el motor de BDD
            //escribir sentencia sql
            string sql = "select Cedula, Apellidos, Nombres, Sexo, FechaNacimiento, Correo, Estatura_Cm, Peso " + "from Datos_Persona " + "where Cedula = '" + Scedula + "'";
            //Definir un adaptador de datos: es un puente que permite pasar los datos de nuestra BDD, hacia el datatable
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@Cedula", Scedula);

            //3. Recuperamos los datos
            DataTable dt = new DataTable();
            ad.Fill(dt);
            DatosPersonas persona = new DatosPersonas();
            if (dt.Rows.Count > 0) //Si existen filas
            {
                foreach(DataRow fila in dt.Rows)
                {
                    persona.Cedula = fila["Cedula"].ToString();
                    persona.Apellidos = fila["Apellidos"].ToString();
                    persona.Nombres = fila["Nombres"].ToString();
                    persona.Sexo = fila["Sexo"].ToString();
                    persona.FechaNacimiento = DateTime.Parse(fila["FechaNacimiento"].ToString());
                    persona.Correo = fila["Correo"].ToString();
                    persona.Estatura = int.Parse(fila["Estatura_Cm"].ToString());
                    persona.Peso = decimal.Parse(fila["Peso"].ToString());
                    break; //Abandonar Bucle
                }
            }
            return persona;
        }
    }
}