<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Group1._3_GradingSystem.HomePage.HomePage" %>

<!DOCTYPE html>
<style>
    #Image1{
        position: fixed;
        top: 26px;
        left: 30px;
    }
    #Image2{
        position: fixed;
        top: 49px;
        left: 1130px;
        height: 32px;
        width: 33px;
    }
    #Label1{
        position: fixed;
        top: 43px;
        left: 145px;
        width: 259px;
    }
    #DropDownList1{
        position: fixed;
        top: 54px;
        left: 1171px;
    }

</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 536px">
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" img src="Image/hopeLogoWhiteBG_.png" runat="server" Height="94px" Width="103px" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Login</asp:ListItem>
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Teacher</asp:ListItem>
            <asp:ListItem>Student</asp:ListItem>
        </asp:DropDownList>
        <asp:Image ID="Image2" img src="Image/ProfileIcon1%20(1).png" runat="server" />
    </form>
</body>
</html>
