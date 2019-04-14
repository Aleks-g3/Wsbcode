<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calendar.aspx.cs" Inherits="WONote.Calender" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="dodaj" />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>Data</HeaderTemplate>
                    
                    
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>ilosc powtorzen</HeaderTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <HeaderTemplate>Cwiczenie</HeaderTemplate>
                </asp:TemplateField>
            </Columns>
            </asp:GridView>
    </form>
</body>
</html>
