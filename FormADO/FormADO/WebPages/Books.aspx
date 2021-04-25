<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="FormADO.WebPages.Books" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="../style.css" />
    <style type="text/css">
        #image1 {
            height: 39px;
            width: 64px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><img src="../Images/book.png" alt="" id="image1" /> Evaluation Form</h1>

            <asp:GridView ID="gridBookList" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />

            </asp:GridView>

            <br />

            <asp:Button ID="btnNewBook" runat="server" Text="New Book" OnClick="btnNewBook_Click"/>
            <asp:Button ID="btnEditBook" runat="server" Text="Edit Book" OnClick="btnEditBook_Click"/>
            <asp:Button ID="btnDeleteBook" runat="server" Text="Delete Book" OnClick="btnDeleteBook_Click"/>
            <asp:Button ID="btnCheckRadioValue" runat="server" Text="Check Radio Value" OnClick="btnCheckRadioValue_Click"/>

            <br />

            <h4><strong>QUESTION 1: </strong>Select the type of installation you want to perform:</h4>

            <asp:RadioButtonList ID="rdoPriceRange" runat="server" RepeatDirection="Horizontal" RepeatLayout="Table" >
                <asp:ListItem Value="1">XBOX</asp:ListItem>
                <asp:ListItem Value="2">Playstation</asp:ListItem>
                <asp:ListItem Value="3">WII</asp:ListItem>
                <asp:ListItem Value="4">Windows</asp:ListItem>
            </asp:RadioButtonList>

            <br />  
            <asp:Label ID="radioValue1" runat="server" Text="test"></asp:Label>
            <br />

            <h4><strong>QUESTION 2: </strong>Please describe the requirements:</h4>

            <asp:TextBox ID="TextBox1" runat="server" TextMode="multiline" style="margin-bottom: 20px" Width="500px" Height="100px"></asp:TextBox>

            <br />



        </div>
    </form>
</body>
</html>
