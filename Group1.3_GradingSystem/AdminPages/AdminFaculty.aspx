<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminFaculty.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminFaculty" enableEventValidation="false"%>

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
        left: 86px;
        height: 27px;
        width: 25px;
    }
#Image6{
    position: fixed;
        top: 272px;
        left: 88px;
        height: 27px;
        width: 24px;
    }
#Image7{
    position: fixed;
        top: 315px;
        left: 85px;
        height: 29px;
        width: 28px;
    }
#Image8{
   position: fixed;
        top: 360px;
        left: 86px;
        height: 26px;
        width: 26px;
    }
#Image9{
    position: fixed;
        top: 403px;
        left: 89px;
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
        top: 100px;
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
        top: 496px;
        left: 765px;
        width: 96px;
    }
#Button2{
    position: fixed;
        top: 495px;
        left: 885px;
        width: 96px;
        height: 29px;
    }
#Button3{
    position: fixed;
        top: 537px;
        left: 765px;
        width: 96px;
    }
#TextBox1{
    position: fixed;
        top: 344px;
        left: 1107px;
    }
#Label15{
    position: fixed;
        top: 250px;
        left: 1086px;
    }
#Button4{
    position: fixed;
        top: 522px;
        left: 1288px;
    }
#Button5{
    position: fixed;
        top: 537px;
        left: 884px;
        height: 29px;
        width: 96px;
    }
#GridView1{
    position: fixed;
        top: 252px;
        left: 791px;
        height: 142px;
        width: 525px;
    }
#TextBox2{
    position: fixed;
        top: 427px;
        left: 314px;
    }
    #TextBox2{
    position: fixed;
        top: 309px;
        left: 1120px;
    }
#Label16{
    position: fixed;
        top: 210px;
        left: 314px;
    }
#TextBox3{
    position: fixed;
        top: 207px;
        left: 384px;
    }
#Label17{
    position: fixed;
        top: 301px;
        left: 1090px;
    }
#TextBox4{
    position: fixed;
        top: 420px;
        left: 407px;
    }
    #TextBox5{
    position: fixed;
        top: 254px;
        left: 1103px;
    }
    #Label18{
        position: fixed;
        top: 421px;
        left: 315px;
    }
    #Label19{
        position: fixed;
        top: 453px;
        left: 316px;
    }
    #Label20{
        position: fixed;
        top: 485px;
        left: 317px;
    }
    #TextBox6{
        position: fixed;
        top: 449px;
        left: 850px;
    }
    #GridView2{
    position: fixed;
        top: 236px;
        left: 755px;
        height: 142px;
        width: 424px;
    }
#GridView3{
    position: fixed;
        top: 236px;
        left: 310px;
        height: 142px;
        width: 424px;
    }
    #Button9{
    position: fixed;
        top: 495px;
        left: 319px;
        width: 96px;
        height: 29px;
        right: 882px;
    }
#Button6{
    position: fixed;
        top: 495px;
        left: 443px;
        width: 96px;
        height: 29px;
    }
#Button7{
    position: fixed;
        top: 537px;
        left: 320px;
        width: 96px;
        height: 29px;
    }
#Button8{
    position: fixed;
        top: 537px;
        left: 442px;
        height: 29px;
        width: 96px;
    }
#TextBox7{
    position: fixed;
        top: 420px;
        left: 852px;
    }
    #Label21{
        position: fixed;
        top: 423px;
        left: 764px;
    }
    #Label20{
        position: fixed;
        top: 452px;
        left: 764px;
    }
    #TextBox8{
        position: fixed;
        top: 453px;
        left: 407px;
    }
    #Button10{
        position: fixed;
        top: 57px;
        left: 1261px;
    }
    #TextBox9{
        position: fixed;
        top: 435px;
        left: 651px;
        width: 42px;
    }
    #Label22{
        position: fixed;
        top: 438px;
        left: 615px;
    }
    #Panel1{
        position: fixed;
    }
    .users{
        position: fixed;
        top: 235px;
        left: 299px;
        width: 440px;
        height: 341px;
        margin-top: 0px;
    }
    ..teachers{
        position: fixed;
        top: 233px;
        left: 753px;
        width: 440px;
        height: 342px;
    }
    #TextBox10{
        position: fixed;
        top: 434px;
        left: 1110px;
        width: 74px;
    }
    #Label23{
        position: fixed;
        top: 439px;
        left: 1074px;
    }
    #TextBox11{
        position: fixed;
        top: 207px;
        left: 842px;
    }
    #Label24{
        position: fixed;
        top: 210px;
        left: 777px;
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
        top: 405px;
        left: 134px;
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
<body style="height: 619px">
    
    <form id="form2" runat="server">
    
        <div>
            <asp:Image ID="Image1" img src="../HomePage/Image/hopeLogoWhiteBG_.png" runat="server" Height="94px" Width="103px" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="HOPE INTERGRATED SCHOOL" Font-Names="Times New Roman"></asp:Label>
        <asp:Image ID="Image2" img src="../HomePage/Image/ProfileIcon1%20(1).png" runat="server" />
    
        <div style="height: 597px; width: 1437px;">
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



            <asp:Label ID="Label14" runat="server" ForeColor="#B03E3E" Text="Manage Faculty Members" Font-Names="Arial" Font-Size="17pt"></asp:Label>
            
            
            
            
            
            <asp:Label ID="Label16" runat="server" Text="Search:"></asp:Label>
            
            <asp:TextBox ID="TextBox3" runat="server" OnTextChanged="TextBox3_TextChanged" AutoPostBack="True"></asp:TextBox>
            
            
            
            
            
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:HIS_GradingSystemConnectionString %>" ProviderName="<%$ ConnectionStrings:HIS_GradingSystemConnectionString.ProviderName %>" SelectCommand="SELECT [user_id], [username], [password] FROM [users]"></asp:SqlDataSource>
            
            &nbsp;
            
            
            
            
            
            
            
            
            
            
            
            <div class ="users" aria-multiline="False">
            <asp:GridView OnSelectedIndexChanged="GridView3_SelectedIndexChanged" OnRowDataBound="GridView3_RowDataBound" OnPageIndexChanging="OnPageIndexChanging" ID="GridView3" runat="server"  CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="4">
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

                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:TextBox ID="TextBox9" runat="server" Height="25px" Width="42px" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>


                <asp:Label ID="Label18" runat="server" Text="Username:"></asp:Label>
                <asp:Label ID="Label19" runat="server" Text="Password:"></asp:Label>
                <asp:Label ID="Label22" runat="server" Text="ID:"></asp:Label>


                <asp:Button ID="Button9" runat="server" Text="+  Add " OnClick="Button9_Click" />
                <asp:Button ID="Button7" runat="server" Text="+ Delete" OnClick="Button7_Click" />
                <asp:Button ID="Button6" runat="server" Text="+ Update" OnClick="Button6_Click" />
                <asp:Button ID="Button8" runat="server" Text=" + Clear" OnClick="Button8_Click" />


            </div>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            
            <asp:Label ID="Label20" runat="server" Text="Lastname:"></asp:Label>
            
            <asp:Label ID="Label21" runat="server" Text="Firstname:"></asp:Label>

            <asp:Button ID="Button10" runat="server" Text="Logout" OnClick="Button10_Click" />
            

            
            
            
            
            <div class ="teachers">
            <asp:GridView OnSelectedIndexChanged="GridView2_SelectedIndexChanged" OnRowDataBound="GridView2_RowDataBound" OnPageIndexChanging="OnPageIndexChangingTeacher" ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="4" >
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


                <asp:Button ID="Button1" runat="server" Text="+  Add " Height="29px" Width="96px" OnClick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="+ Update" Height="29px" Width="96px" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="+ Delete" Height="29px" Width="96px" OnClick="Button3_Click" />
                <asp:Button ID="Button5" runat="server" Text=" + Clear" Height="29px" Width="96px" OnClick="Button5_Click" />




            <asp:Label ID="Label23" runat="server" Text="ID:"></asp:Label>
            
            
            

            </div>
            
            
            
            <asp:TextBox ID="TextBox10" runat="server" Height="25px" Width="42px" Enabled="False"></asp:TextBox>
            
            
            
            <asp:TextBox ID="TextBox11" runat="server" OnTextChanged="TextBox11_TextChanged"></asp:TextBox>
            
            
            
            <asp:Label ID="Label24" runat="server" Text="Search:"></asp:Label>
            
            
            
        </div>

    </form>   
    
</body>
</html>
