<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="crudform.aspx.cs" Inherits="EinsTask2.crudform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <asp:Label ID="idlbl" runat="server" Text="Id"></asp:Label>
          <asp:TextBox ID="idtxt" runat="server"></asp:TextBox><br /><br />


            <asp:Label ID="namelbl" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nametxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="addresslbl" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="addresstxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="statelbl" runat="server" Text="state"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text=" "></asp:ListItem>
                <asp:ListItem Text="Maharashtra "></asp:ListItem>
                <asp:ListItem Text="MP "></asp:ListItem>
                <asp:ListItem Text="UP "></asp:ListItem>

            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="citylbl" runat="server" Text="City"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="citytxt" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="agelbl" runat="server" Text="Age"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="agetxt" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="savebtn" runat="server" Text="Save" style ="margin-right:20px;" OnClick="savebtn_Click"/>
        <asp:Button ID="updatebtn" runat="server" Text="Update" OnClick="updatebtn_Click" /><br /><br />
        <asp:GridView ID="GridView1" runat="server">
            
        </asp:GridView>
    </form>
</body>
</html>
