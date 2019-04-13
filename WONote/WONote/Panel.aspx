<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Panel.aspx.cs" Inherits="WONote.Panel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="en" dir="ltr">
<head runat="server">
    <meta charset="utf-8"/>
    <link rel="stylesheet" href="css/pulpit.css"/>
    <title></title>
</head>
<body>
        <div id="panel">
        <form id="form1" runat="server">
    <label for="username">Nazwa użytkownika:</label>
    <input type="text" id="username" name="username"/>
    <label for="password">Hasło:</label>
    <p><a href="#">Zapomniałeś hasła?</a></p>
    <input type="password" id="password" name="password"/>
    <div id="lower">
    <input type="checkbox"/><label class="check" for="checkbox">Zapamiętaj mnie!</label>
    <input type="submit" value="Login"/>
    </div>
    </form>
    </div>
</body>
</html>
