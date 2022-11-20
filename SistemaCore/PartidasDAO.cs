using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Contracts;
using SistemaCore;

namespace AccesoADatos
{
    public class PartidasDAO
    {
        private static string connectionString;
        private static SqlConnection connection;
        private static SqlCommand command;

        static PartidasDAO()
        {
            connectionString = @"Server = .\ ; Database = ParcialDos ;Trusted_Connection=True;MultipleActiveResultSets=True";

            connection = new SqlConnection(connectionString);
            command = new SqlCommand();

            command.Connection = connection;

            command.CommandType = CommandType.Text;
        }

        public static void AgregarPartida(Partida partida)
        {

            try
            {
                connection.Open();
                command.CommandText = $"INSERT INTO Partidas VALUES (@idJugador1,@cartasJ1,@idJugador2,@cartasJ2,@idGanador,@nombreGanador" +
                    $",@cartasMasCuatro,@cartasMasDos,@cartasBloqueoReversa,@manosJugadas)";
                command.Parameters.AddWithValue("@idJugador1", partida.Jugador1.IdJugador);
                command.Parameters.AddWithValue("@cartasJ1", partida.Jugador1.CartasRestantes);
                command.Parameters.AddWithValue("@idJugador2", partida.Jugador2.IdJugador);
                command.Parameters.AddWithValue("@cartasJ2", partida.Jugador2.CartasRestantes);
                command.Parameters.AddWithValue("@cartasMasCuatro", partida.CantidadMasCuatroUsados);
                command.Parameters.AddWithValue("@cartasMasDos", partida.CantidadMasDosUsados);
                command.Parameters.AddWithValue("@cartasBloqueoReversa", partida.CantidadBloqueoReversa);
                command.Parameters.AddWithValue("@manosJugadas", partida.ManosJugadas);
                if(partida.JugadorGanador==null)
                {
                    command.Parameters.AddWithValue("@idGanador", 0);
                    command.Parameters.AddWithValue("@nombreGanador",string.Empty);
                }
                else
                {
                    command.Parameters.AddWithValue("@idGanador", partida.JugadorGanador.IdJugador);
                    command.Parameters.AddWithValue("@nombreGanador", partida.JugadorGanador.NombreUsuario);
                }
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                command.Parameters.Clear();
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public static void ObtenerEstadisticaJugadorMasGanador(Action<int,string,int> DelegadoEscribirDgv)
        {
            connection.Open();
            command.CommandText = "SELECT IdUsuario AS IdJugadorGanador,NombreUsuario,COUNT(idJugadorGanador) AS PartidasGanadas \r\nFROM Partidas JOIN Usuarios ON idJugadorGanador=IdUsuario\r\nGROUP BY IdUsuario,NombreUsuario\r\nORDER BY PartidasGanadas DESC";
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                DelegadoEscribirDgv(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static void ObtenerEstadisticaCartaAccionMasUtilizadas(Action<string, int> DelegadoEscribirDgv)
        {
            connection.Open();
            command.CommandText = "BEGIN\r\nCREATE TABLE CantidadCartasUtilizadaTemporal\r\n(Cartas VARCHAR(50) NOT NULL, Usos INT NOT NULL)\r\nINSERT INTO CantidadCartasUtilizadaTemporal\r\nVALUES('MasCuatro',(SELECT SUM(CantidadMasCuatro) FROM Partidas)),\r\n('MasDos',(SELECT SUM(CantidadMasDos) FROM Partidas)),\r\n('Especiales',(SELECT SUM(CantidadBloqueoReversa) FROM Partidas))\r\nSELECT * FROM CantidadCartasUtilizadaTemporal\r\nORDER BY Usos DESC\r\nDROP TABLE CantidadCartasUtilizadaTemporal\r\nEND";
            SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                DelegadoEscribirDgv(reader.GetString(0), reader.GetInt32(1));
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public static void ObtenerEstadisticaCantidasPartidas(Action<string> DelegadoEscribirLbl)
        {
            connection.Open();
            command.CommandText = "SELECT COUNT(IdPartida) AS PARTIDAS  FROM Partidas";
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DelegadoEscribirLbl($"La cantidad de partidas registradas en sistema es de: {reader.GetInt32(0)}");
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// PERMITE ESCRIBIR UNA QUERY QUE RETORNARA UN UNICO RESULTADO INT
        /// </summary>
        /// <param name="DelegadoEscribirDgv"></param>
        /// <param name="query"></param>
        /// <param name="mensaje"></param>
        public static void ObtenerEstadisticasInt(Action<string> DelegadoEscribirLbl, string query,string mensaje)
        {
            connection.Open();
            command.CommandText = query;
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                DelegadoEscribirLbl($"{mensaje} {reader.GetInt32(0)}");
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        
        public static void ObtenerEstadisticasHistorialJugadores(int idJugador1,int idJugador2,out int ganadas)
        {
            ganadas = 0;
            connection.Open();
            command.CommandText = $"SELECT COUNT(IdJugadorGanador) as GANADAS\r\n  FROM Partidas\r\n  WHERE (IdJugador1={idJugador1} AND IdJugador2 = {idJugador2} AND IdJugadorGanador=IdJugador1)\r\n  OR (IdJugador1={idJugador2} AND IdJugador2 = {idJugador1} AND IdJugadorGanador=IdJugador2)";
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ganadas = reader.GetInt32(0);
            }

            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
