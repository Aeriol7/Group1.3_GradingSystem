<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSections.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminSections" enableEventValidation="false" %>

<!DOCTYPE html>

<style>
    #Image1{
    position: fixed;
    top: 26px;
    left: 30px;
}
#Image2{
    position: fixed;
    top: 51px;
    left: 1217px;
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
    top: 57px;
    left: 1268px;
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
        bottom: 525px;
    }
#Label4{
    position: fixed;
        top: 228px;
        left: 140px;
    }
#Label5{
    position: fixed;
        top: 272px;
        left: 141px;
        height: 24px;
    }
#Label6{
    position: fixed;
        top: 315px;
        left: 140px;
        bottom: 444px;
    }
#Label7{
    position: fixed;
        top: 359px;
        left: 139px;
    }
#Label8{
    position: fixed;
        top: 403px;
        left: 137px;
    }
#Label9{
    position: fixed;
        top: 519px;
        left: 141px;
    }
#Label11{
    position: fixed;
        top: 114px;
        left: 312px;
    }
#Label10{
    position: fixed;
        top: 115px;
        left: 350px;
        width: 77px;
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
        top: 226px;
        left: 84px;
        height: 27px;
        width: 25px;
    }
#Image6{
    position: fixed;
        top: 270px;
        left: 85px;
        height: 27px;
        width: 24px;
    }
#Image7{
    position: fixed;
        top: 314px;
        left: 84px;
        height: 29px;
        width: 28px;
    }
#Image8{
   position: fixed;
        top: 358px;
        left: 84px;
        height: 26px;
        width: 26px;
    }
#Image9{
    position: fixed;
        top: 402px;
        left: 86px;
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
#Label12{
    position: fixed;
        top: 115px;
        left: 423px;
    }
#Label13{
    position: fixed;
        top: 115px;
        left: 475px;
    }
#Label14{
    position: fixed;
        top: 145px;
        left: 310px;
    }
#Button1{
    position: fixed;
        top: 201px;
        left: 312px;
        width: 147px;
    }
#Button2{
    position: fixed;
        top: 201px;
        left: 483px;
        width: 117px;
    }
#Button3{
    position: fixed;
        top: 201px;
        left: 628px;
        width: 132px;
    }
#TextBox1{
    position: fixed;
        top: 253px;
        left: 1159px;
    }
#Label15{
    position: fixed;
        top: 255px;
        left: 1086px;
    }
#Button4{
    position: fixed;
        top: 522px;
        left: 1288px;
    }
#Button5{
    position: fixed;
        top: 522px;
        left: 1180px;
    }
#Button6{
    position: fixed;
        top: 61px;
        left: 1263px;
    }
    .sections{
        position: fixed;
        top: 235px;
        left: 299px;
        width: 861px;
        height: 468px;
        margin-top: 0px;
    }
    #GridView3{
    position: fixed;
        top: 242px;
        left: 309px;
        height: 142px;
        width: 841px;
    }
    #TextBox9{
        position: fixed;
        top: 510px;
        left: 409px;
        width: 42px;
    }
    #Button10{
    position: fixed;
        top: 160px;
        left: 1071px;
    }
    #TextBox9{
        position: fixed;
        width: 160px;
    }
    #TextBox8{
        position: fixed;
        top: 446px;
        left: 410px;
    }
    #Label18{
        position: fixed;
        top: 451px;
        left: 314px;
        height: 21px;
        width: 97px;
    }
    #Label19{
        position: fixed;
        top: 482px;
        left: 340px;
        height: 27px;
        width: 84px;
    }
    #Label22{
        position: fixed;
        top: 514px;
        left: 310px;
        height: 22px;
        width: 96px;
    }
    #Button9{
        position: fixed;
        top: 443px;
        left: 656px;
    }
    #Button7{
        position: fixed;
        top: 490px;
        left: 656px;
    }
    #Button10{
        position: fixed;
    }
    #Button8{
        position: fixed;
        top: 489px;
        left: 785px;
    }
    #TextBox4{
        position: fixed;
        top: 480px;
        left: 409px;
    }

    #Button11{
        position: fixed;
        top: 443px;
        left: 786px;
        width: 85px;
    }
    
#DropDownList4{
    position: fixed;
        top: 514px;
        left: 409px;
    }
    #AHome{
    position: fixed;
        top: 183px;
        left: 141px;
    }
#ASubj{
    position: fixed;
        top: 228px;
        left: 140px;
    }
#AFaculty{
    position: fixed;
        top: 272px;
        left: 141px;
        height: 24px;
    }
#AStudent{
    position: fixed;
        top: 315px;
        left: 140px;
        bottom: 444px;
    }
#ASection{
position: fixed;
    top: 359px;
    left: 139px;
}
#AApproval{
    position: fixed;
        top: 407px;
        left: 141px;
    }
#IHome{
    position: fixed;
        top: 178px;
        left: 83px;
        height: 27px;
        width: 29px;
    }
#IBook{
    position: fixed;
        top: 227px;
        left: 84px;
        height: 27px;
        width: 25px;
    }
#IClipboard{
    position: fixed;
        top: 272px;
        left: 86px;
        height: 27px;
        width: 24px;
    }
#IPeople{
    position: fixed;
        top: 315px;
        left: 85px;
        height: 29px;
        width: 28px;
    }
#IThree{
   position: fixed;
        top: 360px;
        left: 87px;
        height: 26px;
        width: 26px;
    }
#IApproval{
    position: fixed;
        top: 407px;
        left: 85px;
        height: 24px;
        width: 23px;
    }
    
</style>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form2" runat="server">
    
        <div>
            <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" Height="94px" Width="103px" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman"></asp:Label>
        <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
    
        <div style="height: 731px; width: 1437px;">
        <asp:HyperLink ID="AHome" runat="server" NavigateUrl="AdminHome.aspx" Text="Home" ForeColor="#B03E3E" Font-Underline="False" ></asp:HyperLink>
<asp:HyperLink ID="ASubj" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx" Text="Subjects" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
<asp:HyperLink ID="AFaculty" runat="server" NavigateUrl="~/AdminPages/AdminFaculty.aspx" Text="Faculty" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
<asp:HyperLink ID="AStudent" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx" Text="Students" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
<asp:HyperLink ID="ASection" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx" Text="Sections" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
<asp:HyperLink ID="AApproval" runat="server" NavigateUrl="~/AdminPages/AdminApproval.aspx" Text="Approval" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>

<asp:hyperlink id="link" runat="server" NavigateUrl="~/AdminPages/AdminHome.aspx">
<asp:Image ID="IHome" img src="HomeImages/🦆%20icon%20_home_.png" runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink2" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx">
<asp:Image ID="IBook" img src="HomeImages/🦆%20icon%20_book_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink3" runat="server" NavigateUrl="~/AdminPages/AdminFaculty.aspx">
<asp:Image ID="IClipboard" img src="HomeImages/🦆%20icon%20_clipboard_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink4" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx">
<asp:Image ID="IPeople" img src="HomeImages/🦆%20icon%20_people_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink5" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx">
<asp:Image ID="IThree" img src="HomeImages/🦆%20icon%20_grid%20three%20up_.png"  runat="server" />
</asp:hyperlink>


<asp:hyperlink id="Hyperlink1" runat="server" NavigateUrl="~/AdminPages/AdminApproval.aspx">
<asp:Image ID="IApproval" img src="HomeImages/🦆%20icon%20_dashboard_.png" runat="server" />
</asp:hyperlink>


            <asp:Label ID="Label11" runat="server" Text="Home      " Font-Names="Arial" ForeColor="#B03E3E" Font-Size="7pt"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text="/          Dashboard" Font-Names="Arial" ForeColor="#B03E3E" Font-Size="7pt"></asp:Label>

            <asp:Label ID="Label12" runat="server" Text="/  Subjects" Font-Size="7pt" ForeColor="#B03E3E"></asp:Label>
            
            <asp:Label ID="Label13" runat="server" Text="/  Manage Sections" Font-Size="7pt" ForeColor="#B03E3E"></asp:Label>
            
            <asp:Label ID="Label14" runat="server" ForeColor="#B03E3E" Text="Manage Sections" Font-Names="Arial" Font-Size="17pt"></asp:Label>
            
            <asp:Button ID="Button6" runat="server" Text="Logout" OnClick="Button6_Click" />
            
            
            
            
            
            
            
            
            
            
            
            <div class ="sections" aria-multiline="False">

            <asp:GridView OnSelectedIndexChanged="GridView3_SelectedIndexChanged" OnRowDataBound="GridView3_RowDataBound" OnPageIndexChanging="OnPageIndexChangingsections" ID="GridView3" runat="server"  CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="4">
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

                <asp:TextBox ID="TextBox8" runat="server" Enabled="False"></asp:TextBox>


                <asp:Label ID="Label18" runat="server" Text="Section ID:"></asp:Label>
                <asp:Label ID="Label19" runat="server" Text="Section:"></asp:Label>
                <asp:Label ID="Label22" runat="server" Text="Year Level:"></asp:Label>


                <asp:Button ID="Button9" runat="server" Text="+  Add " OnClick="Button9_Click" Height="29px" Width="96px" />
                <asp:Button ID="Button7" runat="server" Text="+ Delete" OnClick="Button7_Click" Height="29px" Width="96px" />
                <asp:Button ID="Button8" runat="server" Text=" + Clear" OnClick="Button8_Click" Height="29px" Width="96px" />


                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>


                <asp:Button ID="Button11" runat="server" Text="+  Update" OnClick="Button11_Click" Height="29px" Width="96px" />


        
            <asp:DropDownList ID="DropDownList4" runat="server" Height="25px" Width="167px">
                <asp:ListItem Value="0">Select Grade Level</asp:ListItem>
                <asp:ListItem Value="1">Kinder</asp:ListItem>
                <asp:ListItem Value="2">Grade 1</asp:ListItem>
                <asp:ListItem Value="3">Grade 2</asp:ListItem>
                <asp:ListItem Value="4">Grade 3</asp:ListItem>
                <asp:ListItem Value="5">Grade 4</asp:ListItem>
                <asp:ListItem Value="6">Grade 5</asp:ListItem>
                <asp:ListItem Value="7">Grade 6</asp:ListItem>
                <asp:ListItem Value="8">Grade 7</asp:ListItem>
                <asp:ListItem Value="9">Grade 8</asp:ListItem>
                <asp:ListItem Value="10">Grade 9</asp:ListItem>
                <asp:ListItem Value="11">Grade 10</asp:ListItem>
                <asp:ListItem Value="12">Grade 11</asp:ListItem>
                <asp:ListItem Value="13">Grade 12</asp:ListItem>
            </asp:DropDownList>
            
                    
        
            </div>
            
        </div>
    </form>   
    
</body>
</html>
