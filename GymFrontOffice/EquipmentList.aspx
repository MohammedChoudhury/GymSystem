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
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
