<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTranslation.aspx.cs" Inherits="SampleWebFormsApp.AddTranslation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            

        <h2>Add Translation</h2>
        <asp:Label ID="lblWord" runat="server" />
        <br />
        <asp:TextBox ID="txtTranslation" runat="server" />
        <asp:Button ID="btnAdd" runat="server" Text="Add to My Words" OnClick="btnAdd_Click" />

        </div>
    </form>
</body>
</html>
