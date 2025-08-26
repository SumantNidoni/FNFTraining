<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TranslationApp.aspx.cs" Inherits="SampleWebFormsApp.TranslationApp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            

        <h2>Search Word</h2>
        <asp:TextBox ID="txtWord" runat="server" />
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />

        </div>
    </form>
</body>
</html>
