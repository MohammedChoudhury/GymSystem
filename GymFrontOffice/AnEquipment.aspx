<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnEquipment.aspx.cs" Inherits="AnEquipment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Equipment ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEquipmentID" runat="server"></asp:TextBox>
            <br />
            <br />
            Equipment Description&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEquipmentDes" runat="server"></asp:TextBox>
            <br />
            <br />
            Equipment Colour&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtEquipmentClr" runat="server"></asp:TextBox>
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
    </form>
</body>
</html>
