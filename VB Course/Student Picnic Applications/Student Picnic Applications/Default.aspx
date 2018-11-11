<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Student_Picnic_Applications._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Picnic Sign-Up</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Computer Deparment Student Picnic</h2>
        </div>
        <p>
            First Name&nbsp;
            <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
        </p>
        <p>
            Last Name&nbsp;&nbsp;
            <asp:TextBox ID="txtLast" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkVegeterian" runat="server" Text="I am a Vegeterian" />
        </p>
        <p>
            <asp:Button ID="btnConfirm" runat="server" Text="Confirm" />
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
