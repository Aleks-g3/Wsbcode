<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="rej.aspx.cs" Inherits="WONote.rej" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p><label>Imie</label>
            <asp:TextBox runat="server" /></p>
            <p><label>Nazwisko</label>
                <asp:TextBox runat="server" /></p>
            <p><label>E-mail</label>
            <asp:TextBox runat="server" /></p>
            <p><label>Login</label>
            <asp:TextBox runat="server" /></p>
            <p><label>Password</label>
            <asp:TextBox runat="server"/></p>
            <a href="Panel.aspx"><input type="button" id="btn" value="Visit Google" /></a>
        </div>
    </form>
</body>
</html>
