<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLineList.aspx.cs" Inherits="OrderLineList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 267px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderLineList" runat="server" Height="261px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="679px"></asp:ListBox>
        </div>
    </form>
</body>
</html>
