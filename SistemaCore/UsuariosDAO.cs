using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Contracts;
using SistemaCore;

namespace AccesoADatos
{
    public class UsuariosDAO
    {
        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;

        static UsuariosDAO()
        {
            connectionString = @"Server = .\ ; Database = ParcialDos ;Trusted_Connection=True; ";

            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            command.Connection = connection;

            command.CommandType = CommandType.Text;
        }
        public static List<Usuario> ObtenerClientes()
        {
            List<Usuario> usuarios = new List<Usuario>();

            connection.Open();

            command.CommandText = "SELECT * FROM Usuarios";

            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                int idJugador = reader.GetInt32(0);
                string nombreApellido = reader.GetString(1);
                string nombreUsuario = reader.GetString(2);

                Usuario usuarioLeido = new Usuario(idJugador, nombreApellido, nombreUsuario);
                usuarios.Add(usuarioLeido);
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }

            return usuarios;
        }

    }
}
