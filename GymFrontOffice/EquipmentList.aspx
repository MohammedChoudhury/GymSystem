<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EquipmentList.aspx.cs" Inherits="EquipmentList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstEquipmentList" runat="server" Height="452px" OnSelectedIndexChanged="lstEquipmentList_SelectedIndexChanged" Width="546px"></asp:ListBox>
        </div>
        <asp:Button ID="btnadd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
        <br />
        Enter a Equipment Description
        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnapply_click" runat="server" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnclear" runat="server" Text="Clear" OnClick="btnclear_Click" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
