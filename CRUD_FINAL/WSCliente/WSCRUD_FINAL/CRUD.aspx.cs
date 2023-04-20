using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CRUD : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cargarTable();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.ControladorSoapClient WS = new ServiceReference1.ControladorSoapClient();
        bool exito = WS.InsertClientes(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text);
        cargarTable();
        limpiar();
    }

    void cargarTable() {
        ServiceReference1.ControladorSoapClient WS = new ServiceReference1.ControladorSoapClient();
        DataSet resultado = WS.LoadTableCliente();
        GridView1.DataSource = resultado.Tables[0];
        GridView1.DataBind();

    }

    

    void limpiar()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
        TextBox7.Text = "";
        TextBox8.Text = "";
        TextBox9.Text = "";
        TextBox10.Text = "";
        TextBox11.Text = "";

    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        ServiceReference1.ControladorSoapClient WS = new ServiceReference1.ControladorSoapClient();
        bool resultado = WS.DeleteClientes(TextBox1.Text);
        cargarTable();
        limpiar();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        ServiceReference1.ControladorSoapClient WS = new ServiceReference1.ControladorSoapClient();
        bool exito = WS.UpdateCliente(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text);

        cargarTable();
        limpiar();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        ServiceReference1.ControladorSoapClient WS = new ServiceReference1.ControladorSoapClient();

        DataSet resultados = WS.ConsulCliente(TextBox1.Text);
        GridView1.DataSource = resultados.Tables[0];
        GridView1.DataBind();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        cargarTable();
        limpiar();
    }
}