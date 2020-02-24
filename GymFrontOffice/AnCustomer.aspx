﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCustomer.aspx.cs" Inherits="AnCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Customer ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
            <br />
            <br />
            Customer Username&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerUN" runat="server"></asp:TextBox>
            <br />
            <br />
            Customer Firstname&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerFN" runat="server"></asp:TextBox>
            <br />
            <br />
            Customer Lastname&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerLN" runat="server"></asp:TextBox>
            <br />
            <br />
            Date Added&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
            <br />
            <br />
            Customer Active&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="checkActive" runat="server" />
            <br />
            <br />
            <br />
            <asp:Button ID="tbnOK" runat="server" Text="OK" Width="60px" OnClick="tbnOK_Click" />
            <asp:Button ID="tbnCancel" runat="server" Text="Cancel" Width="60px" OnClick="tbnCancel_Click" />
            <br />
        </div>
    </form>
</body>
</html>