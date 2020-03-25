<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteEquipment.aspx.cs" Inherits="DeleteEquipment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" Width="66px" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="margin-left: 32px" Text="No" Width="66px" />
        </div>
    </form>
</body>
</html>
