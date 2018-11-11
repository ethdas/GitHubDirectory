<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Click._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Click Application</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="background-color: #000099">My Click Application </h1>
            <p style="background-color: #9933FF">
                <asp:Button ID="btnClick" runat="server" Text="Click Here" />
            </p>
            <p style="background-color: #3333CC">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
