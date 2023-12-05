<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminSubjects.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminSubjects" enableEventValidation="false"%>

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
    top: 522px;
    left: 414px;
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
        left: 88px;
        height: 27px;
        width: 25px;
    }
#Image6{
    position: fixed;
        top: 271px;
        left: 89px;
        height: 27px;
        width: 24px;
    }
#Image7{
    position: fixed;
        top: 311px;
        left: 89px;
        height: 29px;
        width: 28px;
    }
#Image8{
   position: fixed;
        top: 358px;
        left: 88px;
        height: 26px;
        width: 26px;
        bottom: 411px;
    }
#Image9{
    position: fixed;
        top: 404px;
        left: 90px;
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
        top: 668px;
        left: 394px;
        width: 147px;
        right: 787px;
    }
#Button2{
    position: fixed;
        top: 722px;
        left: 394px;
        width: 117px;
        right: 787px;
    }
#Button3{
    position: fixed;
        top: 670px;
        left: 547px;
        width: 132px;
    }
#TextBox1{
    position: fixed;
        top: 198px;
        left: 1039px;
    }
#Label15{
    position: fixed;
        top: 203px;
        left: 313px;
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
#GridView1{
    position: fixed;
        top: 222px;
        left: 309px;
        height: 228px;
        width: 435px;
        right: 553px;
    }
#Button6{
    position: fixed;
        top: 60px;
        left: 1261px;
    }
    .subject {
        position: fixed;
        height: 571px;
        width: 440px;
        top: 229px;
        left: 303px;
    }
#GridView3{
    position: fixed;
        top: 236px;
        left: 310px;
        height: 142px;
        width: 424px;
        bottom: 189px;
    }
#Button7{
    position: fixed;
        top: 721px;
        left: 546px;
    }
    .teacher {
        height: 428px;
        width: 440px;
    }
    .teacher{
        position: fixed;
        top: 230px;
        left: 957px;
    }
    #GridView2{
        position: fixed;
        top: 236px;
        left: 967px;
    }
    #TextBox2{
        position: fixed;
        top: 481px;
        left: 612px;
        width: 76px;
    }
    #TextBox3{
        position: fixed;
        top: 444px;
        left: 442px;
        width: 147px;
    }
    #DropDownList1{
        position: fixed;
    }
    #Label16{
        position: fixed;
        top: 484px;
        left: 313px;
    }
    #Label17{
        position: fixed;
        top: 526px;
        left: 316px;
        right: 862px;
    }
    #Label18{
        position: fixed;
        top: 483px;
        left: 514px;
    }
    #Label19{
        position: fixed;
        top: 443px;
        left: 314px;
    }
    #TextBox4{
        position: fixed;
        top: 482px;
        left: 416px;
        width: 76px;
    }
    #Label20{
    position: fixed;
        top: 201px;
        left: 975px;
    }
#TextBox5{
    position: fixed;
        top: 203px;
        left: 379px;
    }
#Label21{
    position: fixed;
        top: 563px;
        left: 341px;
    }
#DropDownList2{
    position: fixed;
        top: 559px;
        left: 416px;
    }
    #Label22{
    position: fixed;
        top: 598px;
        left: 329px;
    }
    #DropDownList3{
    position: fixed;
        top: 597px;
        left: 415px;
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
    
        <div style="height: 884px; width: 1437px;">

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
            
            <asp:Label ID="Label13" runat="server" Text="/  Manage Subjects" Font-Size="7pt" ForeColor="#B03E3E"></asp:Label>
            
            <asp:Label ID="Label14" runat="server" ForeColor="#B03E3E" Text="Manage Subjects" Font-Names="Arial" Font-Size="17pt"></asp:Label>
            
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            
            <asp:Button ID="Button6" runat="server" Text="Logout" OnClick="Button6_Click" />
            




                <div class ="subject">

            <asp:GridView OnSelectedIndexChanged="GridView3_SelectedIndexChanged" OnRowDataBound="GridView3_RowDataBound" OnPageIndexChanging="OnPageIndexChangingsubjects" ID="GridView3" runat="server"  CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="4">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775"/>
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

            

            <asp:Button ID="Button1" runat="server" Text="Add" Height="29px" Width="96px" OnClick="Button1_Click" />
            <asp:Button ID="Button3" runat="server" Text="Update" Width="96px" OnClick="Button3_Click" Height="29px" />
            <asp:Button ID="Button2" runat="server" Text="Delete" Width="96px" Height="29px" OnClick="Button2_Click" />
            <asp:Button ID="Button7" runat="server" Text="Clear" Width="96px" Height="29px" OnClick="Button7_Click" />

            <asp:Label ID="Label15" runat="server" Text="Search:"></asp:Label>

                    <asp:DropDownList ID="DropDownList3" runat="server" Height="25px" Width="167px">
                        <asp:ListItem Value="0">Select Category</asp:ListItem>
                        <asp:ListItem Value="1">Language, AP, EsP</asp:ListItem>
                        <asp:ListItem Value="2">Science, Math</asp:ListItem>
                        <asp:ListItem Value="3">MAPEH, EPP/TLE</asp:ListItem>
                        <asp:ListItem Value="4">Academic Subject</asp:ListItem>
                        <asp:ListItem Value="5">Research, Work Immersion</asp:ListItem>
                       </asp:DropDownList>
            
            </div>


            <div class ="teacher" aria-multiline="False">

            <asp:GridView  OnRowDataBound="GridView2_RowDataBound"  ID="GridView2" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="4" Height="142px" Width="424px" >
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


                <asp:TextBox ID="TextBox2" runat="server" Enabled="False"></asp:TextBox>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

                


                <asp:Label ID="Label18" runat="server" Text="Subject ID:"></asp:Label>

                


                <asp:Label ID="Label16" runat="server" Text="Teacher ID:"></asp:Label>
                <asp:Label ID="Label17" runat="server" Text="Year Level:"></asp:Label>
                <asp:Label ID="Label19" runat="server" Text="Subject Name:"></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

            </div>

            <asp:Label ID="Label20" runat="server" Text="Search:"></asp:Label>

                    <asp:DropDownList ID="DropDownList2" runat="server" Height="25px" Width="167px">
                        <asp:ListItem Value="0">Select Section ID</asp:ListItem>
                        <asp:ListItem Value="1">Kinder-A</asp:ListItem>
                        <asp:ListItem Value="2">Grade 1-A</asp:ListItem>
                        <asp:ListItem Value="3">Grade 2-A</asp:ListItem>
                        <asp:ListItem Value="4">Grade 3-A</asp:ListItem>
                        <asp:ListItem Value="5">Grade 4-A</asp:ListItem>
                        <asp:ListItem Value="6">Grade 5-A</asp:ListItem>
                        <asp:ListItem Value="7">Grade 6-A</asp:ListItem>
                        <asp:ListItem Value="8">Grade 7-A</asp:ListItem>
                        <asp:ListItem Value="9">Grade 8-A</asp:ListItem>
                        <asp:ListItem Value="10">Grade 9-A</asp:ListItem>
                        <asp:ListItem Value="11">Grade 10-A</asp:ListItem>
                        <asp:ListItem Value="12">Grade 11-HUMSS</asp:ListItem>
                        <asp:ListItem Value="13">Grade 11-STEM</asp:ListItem>
                        <asp:ListItem Value="14">Grade 12-HUMSS</asp:ListItem>
                        <asp:ListItem Value="15">Grade 12-STEM</asp:ListItem>
                       </asp:DropDownList>
            
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="167px">
                <asp:ListItem>Select Grade Level</asp:ListItem>
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
            <asp:Label ID="Label21" runat="server" Text="Section:"></asp:Label>
            

            
            <asp:Label ID="Label22" runat="server" Text="Category:"></asp:Label>
            

            
        </div>
    </form>   
</body>
</html>
