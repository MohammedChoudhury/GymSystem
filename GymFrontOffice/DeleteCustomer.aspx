<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete the record?<br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" Width="60px" />
            <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" Width="60px" />
        </div>
    </form>
</body>
</html>
