using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Descripción breve de Controlador
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class Controlador : System.Web.Services.WebService
{

    public Controlador()
    {

         
    }
    [WebMethod]
    public DataSet LoadTableCliente()
    {
        string connectionString = "Data Source=DESKTOP-G5TU3V6;Initial Catalog=neptuno;Integrated Security=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM clientes";
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
    public bool InsertClientes(String idCliente, String NombreCompañia, String NombreContacto, String CargoContacto, String Direccion, String Ciudad, String region, String codpostal, String pais, String telefono, String fax)
    {
        string connectionString = "Data Source=DESKTOP-G5TU3V6;Initial Catalog=neptuno;Integrated Security=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "INSERT INTO clientes (idCliente,NombreCompañia,NombreContacto,CargoContacto,Direccion,Ciudad,region,codpostal,pais,telefono,fax) VALUES (@idCliente,@NombreCompañia,@NombreContacto,@CargoContacto,@Direccion,@Ciudad,@region,@codpostal,@pais,@telefono,@fax)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idCliente", idCliente);
                command.Parameters.AddWithValue("@NombreCompañia", NombreCompañia);
                command.Parameters.AddWithValue("@NombreContacto", NombreContacto);
                command.Parameters.AddWithValue("@CargoContacto", CargoContacto);
                command.Parameters.AddWithValue("@Direccion", Direccion);
                command.Parameters.AddWithValue("@Ciudad", Ciudad);
                command.Parameters.AddWithValue("@region", region);
                command.Parameters.AddWithValue("@codpostal", codpostal);
                command.Parameters.AddWithValue("@pais", pais);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@fax", fax);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }

    [WebMethod]
    public bool DeleteClientes(string idCliente)
    {
        string connectionString = "Data Source=DESKTOP-G5TU3V6;Initial Catalog=neptuno;Integrated Security=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "DELETE FROM clientes WHERE idCliente = @idCliente";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idCliente", idCliente);
                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }
        }
    }


    [WebMethod]
    public bool UpdateCliente(String idCliente, String NombreCompañia, String NombreContacto, String CargoContacto, String Direccion, String Ciudad, String region, String codpostal, String pais, String telefono, String fax)
    {
        string connectionString = "Data Source=DESKTOP-G5TU3V6;Initial Catalog=neptuno;Integrated Security=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "UPDATE clientes SET NombreCompañia = @NombreCompañia, NombreContacto = @NombreContacto, CargoContacto = @CargoContacto,Direccion = @Direccion, Ciudad= @Ciudad , region = @region, codpostal = @codpostal, pais = @pais,  telefono =  @telefono, fax = @fax WHERE idCliente = @idCliente";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idCliente", idCliente);
                command.Parameters.AddWithValue("@NombreCompañia", NombreCompañia);
                command.Parameters.AddWithValue("@NombreContacto", NombreContacto);
                command.Parameters.AddWithValue("@CargoContacto", CargoContacto);
                command.Parameters.AddWithValue("@Direccion", Direccion);
                command.Parameters.AddWithValue("@Ciudad", Ciudad);
                command.Parameters.AddWithValue("@region", region);
                command.Parameters.AddWithValue("@codpostal", codpostal);
                command.Parameters.AddWithValue("@pais", pais);
                command.Parameters.AddWithValue("@telefono", telefono);
                command.Parameters.AddWithValue("@fax", fax);

                int rowsAffected = command.ExecuteNonQuery();
                return rowsAffected > 0;
            }

        }
    }

    [WebMethod]
    public DataSet ConsulCliente(string idCliente)
    {
        string connectionString = "Data Source=DESKTOP-G5TU3V6;Initial Catalog=neptuno;Integrated Security=True;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            string query = "SELECT * FROM clientes WHERE idCliente = @idCliente";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@idCliente", idCliente);
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
