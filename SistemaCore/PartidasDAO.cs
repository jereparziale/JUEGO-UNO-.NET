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
            connectionString = @"Server = .\ ; Database = ParcialDos ;Trusted_Connection=True; ";

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

    }
}
