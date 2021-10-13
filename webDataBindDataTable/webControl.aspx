<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webControl.aspx.cs" Inherits="webDataBindDataTable.webControl" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="cboTeams" runat="server" AutoPostBack="true" OnSelectedIndexChanged="cboTeams_SelectedIndexChanged"></asp:DropDownList>
        <br /> <br />
        <asp:Label ID="lblResult" runat="server" BackColor="#99cc00"></asp:Label>

    </form>
</body>
</html>
