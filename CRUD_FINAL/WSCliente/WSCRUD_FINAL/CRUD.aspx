<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CRUD.aspx.cs" Inherits="CRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <style type="text/css">

        .btn {
  border: none;
  color: white;
  padding: 14px 28px;
  font-size: 16px;
  cursor: pointer;
}

.success {background-color: #04AA6D;} /* Green */
.success:hover {background-color: #46a049;}

.info {background-color: #2196F3;} /* Blue */
.info:hover {background: #0b7dda;}

.warning {background-color: #ff9800;} /* Orange */
.warning:hover {background: #e68a00;}

.danger {background-color: #f44336;} /* Red */ 
.danger:hover {background: #da190b;}

.default {background-color: #066699; color: white;} /* Gray */ 
.default:hover {background: #0a5483;}


        body {
  margin: 0;
  font-family: Arial, Helvetica, sans-serif;
}

.topnav {
  overflow: hidden;
  background-color: #333;
}

.topnav a {
  float: left;
  color: #f2f2f2;
  text-align: center;
  padding: 14px 16px;
  text-decoration: none;
  font-size: 17px;
}

.topnav a:hover {
  background-color: #ddd;
  color: black;
}

.topnav a.active {
  background-color: #04AA6D;
  color: white;
}

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 26px;
        }
        .auto-style3 {
            width: 258px;
        }
        .auto-style4 {
            height: 26px;
            width: 258px;
        }
        .auto-style5 {
            width: 204px;
        }
        .auto-style6 {
            height: 26px;
            width: 204px;
        }
        .auto-style7 {
            width: 129px;
        }
        .auto-style8 {
            height: 26px;
            width: 129px;
        }
        .auto-style9 {
            width: 347px;
        }
        .auto-style11 {
            height: 26px;
            width: 347px;
        }
        .auto-style12 {
            width: 487px;
        }
    </style>
    
</head>
<body>    
    <form id="form1" runat="server">
        <div class="topnav">
  <a class="active" href="#home">INICIO</a>
  <a href="#news">NOTICIAS</a>
  <a href="#contact">CONTACTOS</a>
  <a href="#about">ACERCA</a>
</div>

<div style="padding-left:16px">
  <center><h2>CRUD ASP.NET CON SQL</h2></center>  
</div>

        <div >
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style5">IDCliente</td>
                    <td class="auto-style3">
            <asp:TextBox ID="TextBox1" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">Region</td>
                    <td>
            <asp:TextBox ID="TextBox7" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style5">Nombre de Compañia</td>
                    <td class="auto-style3">
            <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">Codigo Postal</td>
                    <td>
            <asp:TextBox ID="TextBox8" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style5">Nombre de Contacto</td>
                    <td class="auto-style3">
            <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">Pais</td>
                    <td>
            <asp:TextBox ID="TextBox9" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style5">Cargo de Contacto</td>
                    <td class="auto-style3">
            <asp:TextBox ID="TextBox4" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">Telefono</td>
                    <td>
            <asp:TextBox ID="TextBox10" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style6">Direccion</td>
                    <td class="auto-style4">
            <asp:TextBox ID="TextBox5" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style8">Fax</td>
                    <td class="auto-style2">
            <asp:TextBox ID="TextBox11" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style5">Ciudad</td>
                    <td class="auto-style3">
            <asp:TextBox ID="TextBox6" runat="server" Font-Size="Medium" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td>
            <asp:Button class="btn success" ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" Font-Bold="True" />
            <asp:Button class="btn danger" ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" Font-Bold="True"  />
            <asp:Button class="btn warning" ID="Button3" runat="server" OnClick="Button3_Click" Text="Actualizar" Font-Bold="True"  />
            <asp:Button class="btn info" ID="Button4" runat="server" OnClick="Button4_Click" Text="Consultar" Font-Bold="True"  />
            <asp:Button class="btn default" ID="Button5" runat="server" OnClick="Button5_Click" Text="Cargar" Font-Bold="True" Width="100px" />      
                    </td>
                </tr>
            </table>
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            </div>
            </div>
    </form>
    
</body>
</html>
