<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WS_Compania.aspx.cs" Inherits="WS_Compania" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 466px">
            Lista de Compañías de Envíos<br />
            <br />
            Id Compañía<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Nombre de la compañía<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Teléfono<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insertar" />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Eliminar" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Actualizar" />
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Consultar" />
            <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Cargar" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>           
        </div>
    </form>
</body>
</html>
