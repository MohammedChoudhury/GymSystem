<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineList.aspx.cs" Inherits="OrderLineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 431px;
            width: 708px;
        }
    </style>
</head>
<body style="height: 267px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderLineList" runat="server" Height="261px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="679px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="Button1_Click" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="Button2_Click" Text="Delete" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <br />
        <br />
        Enter a customer name
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
    </form>
</body>
</html>
