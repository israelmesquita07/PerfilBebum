<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link rel="stylesheet" href="../Content/css/style.css" />
</head>
<body>
    <div class="wrapper">
        <div class="container">
            <form id="form1" runat="server" class="form">
                <div>
                    <h1>Perfil do Bebum</h1>
                    <asp:Label ID="lblBebidas" runat="server" Text="Bebidas"></asp:Label>
                    <asp:DropDownList ID="ddlBebidas" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBebidas_SelectedIndexChanged">
                    </asp:DropDownList>
                    <asp:Label ID="lblDoses" runat="server" Text="Doses"></asp:Label>
                    <asp:DropDownList ID="ddlDoses" runat="server">
                    </asp:DropDownList>
                    <asp:Button ID="btnGerarPerfil" runat="server" Text="GERAR PERFIL" OnClick="btnGerarPerfil_Click" />
                </div>
            </form>
        </div>
    </div>
</body>
</html>
