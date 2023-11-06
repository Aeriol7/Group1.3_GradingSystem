<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminLogin" %>

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
#Image3{
    position: fixed;
        top: 169px;
        left: 338px;
        height: 95px;
        width: 109px;
    }
#Image4{
    position: fixed;
        top: 373px;
        left: 546px;
    }
#Image5{
    position: fixed;
        top: 415px;
        left: 545px;
        height: 26px;
        width: 30px;
        right: 722px;
    }
#Image6{
    position: fixed;
        top: 156px;
        left: 611px;
        height: 371px;
        width: 638px;
    }
#Label1{
    position: fixed;
    top: 43px;
    left: 145px;
    width: 201px;
}
#Label2{
    position: fixed;
        top: 261px;
        left: 307px;
        width: 55px;
        height: 25px;
    }
#Label3{
    position: fixed;
        top: 260px;
        left: 366px;
        height: 24px;
    }
#Label4{
    position: fixed;
        top: 281px;
        left: 346px;
    }
#DropDownList1{
    position: fixed;
    top: 52px;
    left: 1171px;
} 
#TextBox1{
    position: fixed;
        top: 329px;
        left: 216px;
        width: 354px;
    }
#TextBox2{
    position: fixed;
        top: 374px;
        left: 216px;
        width: 315px;
    }
#TextBox3{
    position: fixed;
        top: 418px;
        left: 217px;
        width: 314px;
    }
#Panel1{
    position: fixed;
}
#Button1{
    position: fixed;
        top: 466px;
        left: 354px;
        width: 64px;
    }
body{
    width: 1273px;
        height: 545px;
    }
</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
            <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" Height="94px" Width="103px" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman"></asp:Label>
        <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Selected="True">Admin</asp:ListItem>
            <asp:ListItem>Home</asp:ListItem>
            <asp:ListItem>Teacher</asp:ListItem>
            <asp:ListItem>Student</asp:ListItem>
        </asp:DropDownList>
        
        <asp:Image ID="Image3" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" />
        
        <asp:Label ID="Label2" runat="server" Text="HOPE" ForeColor="Yellow" Font-Bold="True" Font-Names="Arial"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="INTERGRATED" ForeColor="Red" Font-Bold="True" Font-Names="Arial"></asp:Label>
        <asp:Label ID="Label4" runat="server" Text="SCHOOL" ForeColor="Blue" Font-Bold="True" Font-Names="Arial"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Font-Bold="True" Font-Names="Arial">Admin Login</asp:TextBox>
        
        <asp:TextBox ID="TextBox2" runat="server">Username</asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server">Password</asp:TextBox>
        <asp:Image ID="Image4" img src="LoginImages/ic_outline-alternate-email.png" runat="server" Height="24px" Width="27px" />
        
        <asp:Image ID="Image5" img src="LoginImages/mdi_eye.png" runat="server" />
        
        <asp:Button ID="Button1" OnClick="btnLogin_Click" runat="server" Text="Login" BackColor="#0066FF" Font-Bold="False" ForeColor="White" />
        <asp:Image ID="Image6" img src="LoginImages/FormGroup1Graphics.png" runat="server" />
    </form>
     
</body>
</html>
