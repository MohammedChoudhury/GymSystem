﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCustomerList" runat="server" Height="506px" OnSelectedIndexChanged="lstCustomerList_SelectedIndexChanged" Width="552px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="60px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="60px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
&nbsp;<br />
        <br />
        Enter a Last Name&nbsp;&nbsp;
        <asp:TextBox ID="txtFilter" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" Width="60px" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="margin-top: 0px" Text="Clear" Width="60px" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>
