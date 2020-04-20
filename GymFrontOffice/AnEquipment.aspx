<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnEquipment.aspx.cs" Inherits="AnEquipment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Equipment No&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEquipmentNo" runat="server"></asp:TextBox>
            <asp:Button ID="tbnFind" runat="server" Text="Find" OnClick="tbnFind_Click" Width="60px" />
            <br />
            <br />
            Equipment Description&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEquipmentDescription" runat="server" OnTextChanged="txtEquipmentDescription_TextChanged"></asp:TextBox>
            <br />
            <br />
            Equipment Colour&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEquipmentColour" runat="server"></asp:TextBox>
            <br />
            <br />
            Equipment Date Added&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtDateAdded" runat="server"></asp:TextBox>
            <br />
            <br />
            Equipment Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEquipmentPrice" runat="server"></asp:TextBox>
            <br />
            <br />
            Equipment Available&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:CheckBox ID="chkAvailable" runat="server" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="tbnOK" runat="server" Text="OK" OnClick="tbnOK_Click" Width="60px" />
            <asp:Button ID="tbnCancel" runat="server" Text="Cancel" OnClick="tbnCancel_Click" Width="60px" />
            <br />
        </div>
        <asp:Label ID="lblError" runat="server" Text=" No Errors"></asp:Label>
    </form>
</body>
</html>
