using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ChatBidireccional
{

    public class ChatFuncion
    {
        public string conexion;

        public ChatFuncion(string conexionString)
        {
            conexion = conexionString;
        }

        public void EnviarMensaje(string remitente, string destinatario, string texto, DateTime fecha)
        {
            using (SqlConnection con = new SqlConnection(conexion)) 
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INS_MENSAJES", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Remitente", remitente);
                cmd.Parameters.AddWithValue("@Destinatario", destinatario);
                cmd.Parameters.AddWithValue("@Mensaje", texto);
                cmd.Parameters.AddWithValue("@FechaEnvio", fecha);

                cmd.ExecuteNonQuery();
            }
        }

        public void MarcarLeido(int Id)
        {
            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPD_MENSAJE", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
             
                cmd.ExecuteNonQuery();
            }
        }

        public List<string> RecibirMensaje(string destinatario)
        {
            List<string> mensajes = new List<string>();
            List<int> ids = new List<int>();

            using (SqlConnection con = new SqlConnection(conexion))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SEL_MENSAJE", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Destinatario", destinatario);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    mensajes.Add($"{reader["Remitente"]}: {reader["Mensaje"]}");
                    ids.Add((int)reader["Id"]);
                }
                reader.Close();
            }

            foreach (var id in ids)
            {
                MarcarLeido(id);
            }

            return mensajes;
        }

    }
}
