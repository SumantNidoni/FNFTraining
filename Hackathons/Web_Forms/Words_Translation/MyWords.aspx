<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyWords.aspx.cs" Inherits="SampleWebFormsApp.MyWords" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
<h2>My Words</h2>
        <asp:GridView ID="gvWords" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Key" HeaderText="Word" />
                <asp:BoundField DataField="Value" HeaderText="Translation" />
            </Columns>
        </asp:GridView>

        </div>
    </form>
</body>
</html>
