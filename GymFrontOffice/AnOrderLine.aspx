<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrderLine.aspx.cs" Inherits="AnOrderLine" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Order No&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtOrderNo" runat="server" Width="98px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Find" />
            <br />
            <br />
            Equipment Ordered&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtEquipmentOrdered" runat="server"></asp:TextBox>
            <br />
            <br />
            Total Cost&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtTotalCost" runat="server"></asp:TextBox>
            <br />
            <br />
            Customer Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
            <br />
            <br />
            Date Processed&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDateProcessed" runat="server"></asp:TextBox>
            <br />
            <br />
            Order Processed&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkProcessed" runat="server" OnCheckedChanged="chkProcessed_CheckedChanged" />
            <br />
            <asp:Label ID="lblError" runat="server" BackColor="White" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" Width="60px" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            <br />
        </div>
    </form>
</body>
</html>
