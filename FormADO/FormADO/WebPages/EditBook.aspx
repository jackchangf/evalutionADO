<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditBook.aspx.cs" Inherits="FormADO.WebPages.EditBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../style.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Edit Book</h1>

            <asp:Label ID="lblTitle" runat="server" Text="Title: "></asp:Label>
            <br />
            <asp:TextBox ID="txtTitle" runat="server" Width="300px"></asp:TextBox>
            <br />

            <asp:Label ID="lblIsbn" runat="server" Text="ISBN: "></asp:Label>
            <br />
            <asp:TextBox ID="txtIsbn" runat="server" Width="300px"></asp:TextBox>
            <br />

            <asp:Label ID="lblPublisher" runat="server" Text="Publisher: "></asp:Label>
            <br />
            <asp:TextBox ID="txtPublisher" runat="server" Width="300px"></asp:TextBox>
            <br />

            <asp:Label ID="lblAuthor" runat="server" Text="Author:"></asp:Label>
            <br />
            <asp:TextBox ID="txtAuthor" runat="server" Width="300px"></asp:TextBox>
            <br />

            <asp:Label ID="lblCategory" runat="server" Text="Category:"></asp:Label>
            <br />
            <asp:TextBox ID="txtCategory" runat="server" Width="300px"></asp:TextBox>
            <br />

            <p />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />

            <br />

            <h4><strong>QUESTION 1: </strong>Select the type of installation you want to perform:</h4>

            <asp:RadioButtonList ID="radioQuestion1" runat="server" RepeatDirection="Horizontal" RepeatLayout="Table" >
                <asp:ListItem Value="1">XBOX</asp:ListItem>
                <asp:ListItem Value="2">Playstation</asp:ListItem>
                <asp:ListItem Value="3">WII</asp:ListItem>
                <asp:ListItem Value="4">Windows</asp:ListItem>
            </asp:RadioButtonList>

            <br />  
            <asp:Label ID="radioValue1" runat="server" Text="test"></asp:Label>
            <br />

            <h4><strong>QUESTION 2: </strong>Please describe the requirements:</h4>

            <asp:TextBox ID="txtQuestion2" runat="server" TextMode="multiline" style="margin-bottom: 20px" Width="500px" Height="100px"></asp:TextBox>

            <br />

        </div>
    </form>
</body>
</html>
