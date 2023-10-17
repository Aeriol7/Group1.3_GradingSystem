<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminHome" %>

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
#Label2{
    position: fixed;
        top: 183px;
        left: 141px;
    }
#Label3{
   position: fixed;
        top: 231px;
        left: 140px;
    }
#Label4{
    position: fixed;
        top: 283px;
        left: 141px;
    }
#Label5{
    position: fixed;
        top: 339px;
        left: 141px;
        height: 24px;
    }
#Label6{
    position: fixed;
        top: 386px;
        left: 141px;
        bottom: 167px;
    }
#Label7{
    position: fixed;
        top: 429px;
        left: 141px;
    }
#Label8{
    position: fixed;
        top: 476px;
        left: 141px;
    }
#Label9{
    position: fixed;
        top: 526px;
        left: 141px;
    }
#Label11{
    position: fixed;
        top: 114px;
        left: 312px;
    }
#Label10{
    position: fixed;
        top: 113px;
        left: 422px;
    }
#Image3{
    position: fixed;
        top: 178px;
        left: 83px;
        height: 27px;
        width: 29px;
    }
#Image4{
   position: fixed;
        top: 228px;
        left: 83px;
        height: 27px;
        width: 29px;
    }
#Image5{
    position: fixed;
        top: 283px;
        left: 85px;
        height: 27px;
        width: 25px;
    }
#Image6{
    position: fixed;
        top: 337px;
        left: 84px;
        height: 27px;
        width: 24px;
    }
#Image7{
    position: fixed;
        top: 385px;
        left: 84px;
        height: 29px;
        width: 28px;
    }
#Image8{
   position: fixed;
        top: 429px;
        left: 85px;
        height: 26px;
        width: 26px;
    }
#Image9{
    position: fixed;
        top: 475px;
        left: 85px;
        height: 24px;
        width: 23px;
    }
#Image10{
    position: fixed;
        top: 522px;
        left: 85px;
        height: 30px;
        width: 27px;
    }
#Image11{
    position: fixed;
        top: 96px;
        left: 278px;
        height: 479px;
        width: 985px;
    }
</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body style="height: 546px">
    
        <div>
            <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" Height="94px" Width="103px" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Admin</asp:ListItem>
            <asp:ListItem>Logout</asp:ListItem>
        </asp:DropDownList>
        <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
    
    <form id="form1" runat="server">
        <div style="height: 546px">
            <asp:Label ID="Label2" runat="server" Text="Home" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="Dashboard" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label4" runat="server" Text="Subjects" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Faculty" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="Students" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label7" runat="server" Text="Sections" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label8" runat="server" Text="School Year" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label9" runat="server" Text="Back-up" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label11" runat="server" Text="WELCOME," Font-Names="Arial" ForeColor="#B03E3E"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text="ADMIN" Font-Names="Arial" ForeColor="#33CC33"></asp:Label>

            <asp:Image ID="Image3" img src="HomeImages/🦆%20icon%20_home_.png" runat="server" />
            <asp:Image ID="Image4" img src="HomeImages/🦆%20icon%20_dashboard_.png"  runat="server" />
            <asp:Image ID="Image5" img src="HomeImages/🦆%20icon%20_book_.png"  runat="server" />
            <asp:Image ID="Image6" img src="HomeImages/🦆%20icon%20_clipboard_.png"  runat="server" />
            <asp:Image ID="Image7" img src="HomeImages/🦆%20icon%20_people_.png"  runat="server" />
            <asp:Image ID="Image8" img src="HomeImages/🦆%20icon%20_grid%20three%20up_.png"  runat="server" />
            <asp:Image ID="Image9" img src="HomeImages/🦆%20icon%20_calendar_.png"  runat="server" />
            <asp:Image ID="Image10" img src="HomeImages/🦆%20icon%20_data%20transfer%20upload_.png"  runat="server" />
            <asp:Image ID="Image11" img src="HomeImages/Graphic1.png"  runat="server" />
            
        </div>
    </form>
</body>
</html>
