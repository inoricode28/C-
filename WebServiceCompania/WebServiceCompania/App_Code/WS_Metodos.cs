using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de WS_Metodos
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class WS_Metodos : System.Web.Services.WebService
{

    public WS_Metodos()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }    

    [WebMethod]
    public DataSet CargarTablaCompañia()
    {
        string connectionString = "Data Source=DESKTOP-G5TU3V6;Initial Catalog=neptuno;Integrated Security=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM compañiasdeenvios";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
        }
    }

    [WebMethod]
    public bool InsertarCompañia(int idCompañiaEnvios, string nombreCompañia, string telefono)
    {
        string connectionString = "Data Source=DESKTOP-G5TU3V6;Initial Catalog=neptuno;Integrated Security=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO compañiasdeenvios (idCompañiaEnvios, nombreCompañia, telefono) VALUES (@idCompañiaEnvios, @nombreCompañia, @telefono)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idCompañiaEnvios", idCompañiaEnvios);
                command.Parameters.AddWithValue("@nombreCompañia", nombreCompañia);
                command.Parameters.AddWithValue("@telefono", telefono);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

    [WebMethod]
    public bool EliminarCompañia(int idCompañiaEnvios)
    {
        string connectionString = "Data Source=DESKTOP-G5TU3V6;Initial Catalog=neptuno;Integrated Security=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM compañiasdeenvios WHERE idCompañiaEnvios = @idCompañiaEnvios";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idCompañiaEnvios", idCompañiaEnvios);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

    [WebMethod]
    public bool ActualizarCompañia(int idCompañiaEnvios, string nombreCompañia, string telefono)
    {
        string connectionString = "Data Source=DESKTOP-G5TU3V6;Initial Catalog=neptuno;Integrated Security=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "UPDATE compañiasdeenvios SET nombreCompañia = @nombreCompañia, telefono = @telefono WHERE idCompañiaEnvios = @idCompañiaEnvios";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idCompañiaEnvios", idCompañiaEnvios);
                command.Parameters.AddWithValue("@nombreCompañia", nombreCompañia);
                command.Parameters.AddWithValue("@telefono", telefono);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

    [WebMethod]
    public DataSet ConsultarCompañia(int idCompañiaEnvios)
    {
        string connectionString = "Data Source=DESKTOP-G5TU3V6;Initial Catalog=neptuno;Integrated Security=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM compañiasdeenvios WHERE idCompañiaEnvios = @idCompañiaEnvios";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idCompañiaEnvios", idCompañiaEnvios);
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);
                    return dataSet;
                }
            }
        }
    }



}
