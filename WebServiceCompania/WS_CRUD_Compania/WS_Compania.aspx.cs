using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WS_Compania : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        cargar();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        ServiceReference1.WS_MetodosSoapClient WS = new ServiceReference1.WS_MetodosSoapClient();
        bool exito = WS.InsertarCompañia(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text);


        cargar();
        limpiar();
    }

    void cargar()
    {
        ServiceReference1.WS_MetodosSoapClient WS = new ServiceReference1.WS_MetodosSoapClient();
        DataSet resultado = WS.CargarTablaCompañia();
        GridView1.DataSource = resultado.Tables[0];
        GridView1.DataBind();
    }

    void limpiar()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        ServiceReference1.WS_MetodosSoapClient WS = new ServiceReference1.WS_MetodosSoapClient();

        bool exito = WS.EliminarCompañia(Convert.ToInt32(TextBox1.Text));

        cargar();
        limpiar();
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        ServiceReference1.WS_MetodosSoapClient WS = new ServiceReference1.WS_MetodosSoapClient();

        bool exito = WS.ActualizarCompañia(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text);

        cargar();
        limpiar();
    }


    protected void Button4_Click(object sender, EventArgs e)
    {
        ServiceReference1.WS_MetodosSoapClient WS = new ServiceReference1.WS_MetodosSoapClient();

        DataSet resultados = WS.ConsultarCompañia(Convert.ToInt32(TextBox1.Text));
        GridView1.DataSource = resultados.Tables[0];
        GridView1.DataBind();
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        cargar();
        limpiar();
    }
}