<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminStudent.aspx.cs" Inherits="Group1._3_GradingSystem.AdminPages.AdminStudent" enableEventValidation="false" %>

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
    top: 559px;
    left: 425px;
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
        top: 488px;
        left: 426px;
    }
#Label15{
    position: fixed;
        top: 528px;
        left: 340px;
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
        top: 62px;
        left: 1263px;
    }
    .subject {
        position: fixed;
        height: 508px;
        width: 440px;
        top: 231px;
        left: 313px;
    }
#GridView3{
    position: fixed;
        top: 234px;
        left: 311px;
        height: 142px;
        width: 424px;
        bottom: 358px;
    }
#Button8{
    position: fixed;
        top: 640px;
        left: 381px;
        width: 147px;
    }
#Button10{
    position: fixed;
        top: 679px;
        left: 381px;
        width: 117px;
    }
#Button9{
    position: fixed;
        top: 640px;
        left: 506px;
        width: 132px;
        right: 675px;
    }
#Label16{
    position: fixed;
        top: 255px;
        left: 1086px;
    }
#Button7{
    position: fixed;
        top: 679px;
        left: 506px;
    }
#Label15{
    position: fixed;
}
#Label16{
    position: fixed;
        top: 450px;
        left: 319px;
    }
#Label16{
    position: fixed;
}
#Label17{
    position: fixed;
        top: 447px;
        left: 604px;
    }
#Label17{
    position: fixed;
}
#TextBox1{
    position: fixed;
}
#TextBox2{
    position: fixed;
        top: 558px;
        left: 425px;
    }
#TextBox2{
    position: fixed;
        width: 37px;
    }
#TextBox3{
    position: fixed;
        top: 452px;
        left: 426px;
    }
#TextBox3{
    position: fixed;
}
#Label18{
    position: fixed;
        top: 489px;
        left: 319px;
    }
#Label18{
    position: fixed;
}
#TextBox4{
    position: fixed;
        top: 446px;
        left: 701px;
    }
#TextBox4{
    position: fixed;
        width: 37px;
    }
#Label19{
    position: fixed;
        top: 561px;
        left: 319px;
    }
#Label19{
    position: fixed;
}
#TextBox5{
    position: fixed;
        top: 525px;
        left: 427px;
    }
#TextBox5{
    position: fixed;
        width: 37px;
        right: 805px;
    }
#DropDownList3{
    position: fixed;
        top: 527px;
        left: 620px;
        width: 104px;
        right: 553px;
    }
#Label20{
    position: fixed;
        top: 593px;
        left: 344px;
    }
#Label20{
    position: fixed;
}
#DropDownList2{
    position: fixed;
        top: 589px;
        left: 424px;
    }
#Label21{
    position: fixed;
        top: 576px;
        left: 787px;
    }
#Label21{
    position: fixed;
}
#TextBox6{
    position: fixed;
        top: 527px;
        left: 624px;
    }
#TextBox6{
    position: fixed;
        width: 74px;
    }
#Button12{
    position: fixed;
        top: 679px;
        left: 381px;
        width: 117px;
    }
#Button11{
    position: fixed;
        top: 640px;
        left: 506px;
        width: 132px;
        right: 675px;
    }
#Label22{
    position: fixed;
        top: 255px;
        left: 1086px;
    }
#Label22{
    position: fixed;
        top: 586px;
        left: 97px;
    }
#Label22{
    position: fixed;
}
#Label23{
    position: fixed;
        top: 287px;
        left: 758px;
    }
#Label23{
    position: fixed;
}
#TextBox7{
    position: fixed;
        top: 448px;
        left: 426px;
    }
#TextBox7{
    position: fixed;
}
#Label24{
    position: fixed;
        top: 547px;
        left: 152px;
    }
#Label24{
    position: fixed;
}
#TextBox8{
    position: fixed;
        top: 438px;
        left: 837px;
    }
#TextBox8{
    position: fixed;
        width: 37px;
    }
#Label25{
    position: fixed;
        top: 527px;
        left: 511px;
    }
#Label25{
    position: fixed;
}
#TextBox9{
    position: fixed;
        top: 557px;
        left: 792px;
    }
#TextBox9{
    position: fixed;
        width: 37px;
    }
    .sections {
        position: fixed;
        height: 508px;
        width: 439px;
        top: 233px;
        left: 976px;
    }
    #GridView1{
        position: fixed;
        top: 237px;
        left: 315px;
    }
    #GridView2{
    position: fixed;
    top: 237px;
    left: 982px;
}
#DropDownList4{
    position: fixed;
        top: 561px;
        left: 424px;
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
    
        <div style="height: 827px; width: 1437px;">
            <asp:HyperLink ID="Label2" runat="server" NavigateUrl="AdminHome.aspx" Text="Home" ForeColor="#B03E3E" Font-Underline="False" ></asp:HyperLink>
            <asp:HyperLink ID="Label3" runat="server" NavigateUrl="~/AdminPages/AdminDashboard.aspx" Text="Dashboard" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="Label4" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx" Text="Subjects" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="Label5" runat="server" NavigateUrl="~/AdminPages/AdminFaculty.aspx" Text="Faculty" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="Label6" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx" Text="Students" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="Label7" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx" Text="Sections" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:HyperLink ID="Label8" runat="server" NavigateUrl="~/AdminPages/AdminSchoolYearCalendar.aspx" Text="School Year" ForeColor="#B03E3E" Font-Underline="False"></asp:HyperLink>
            <asp:Label ID="Label11" runat="server" Text="Home      " Font-Names="Arial" ForeColor="#B03E3E" Font-Size="7pt"></asp:Label>
            <asp:Label ID="Label10" runat="server" Text="/          Dashboard" Font-Names="Arial" ForeColor="#B03E3E" Font-Size="7pt"></asp:Label>

            <asp:hyperlink id="link" runat="server" NavigateUrl="~/AdminPages/AdminHome.aspx">
<asp:Image ID="Image3" img src="HomeImages/🦆%20icon%20_home_.png" runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink1" runat="server" NavigateUrl="~/AdminPages/AdminDashboard.aspx">
<asp:Image ID="Image4" img src="HomeImages/🦆%20icon%20_dashboard_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink2" runat="server" NavigateUrl="~/AdminPages/AdminSubjects.aspx">
<asp:Image ID="Image5" img src="HomeImages/🦆%20icon%20_book_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink3" runat="server" NavigateUrl="~/AdminPages/AdminFaculty.aspx">
<asp:Image ID="Image6" img src="HomeImages/🦆%20icon%20_clipboard_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink4" runat="server" NavigateUrl="~/AdminPages/AdminStudent.aspx">
<asp:Image ID="Image7" img src="HomeImages/🦆%20icon%20_people_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink5" runat="server" NavigateUrl="~/AdminPages/AdminSections.aspx">
<asp:Image ID="Image8" img src="HomeImages/🦆%20icon%20_grid%20three%20up_.png"  runat="server" />
</asp:hyperlink>

<asp:hyperlink id="Hyperlink6" runat="server" NavigateUrl="~/AdminPages/AdminSchoolYearCalendar.aspx">
<asp:Image ID="Image9" img src="HomeImages/🦆%20icon%20_calendar_.png"  runat="server" />
</asp:hyperlink>


            <asp:Label ID="Label12" runat="server" Text="/  Subjects" Font-Size="7pt" ForeColor="#B03E3E"></asp:Label>
            
            <asp:Label ID="Label13" runat="server" Text="/  Manage Students" Font-Size="7pt" ForeColor="#B03E3E"></asp:Label>
            
            <asp:Label ID="Label14" runat="server" ForeColor="#B03E3E" Text="Manage Students" Font-Names="Arial" Font-Size="17pt"></asp:Label>
            
            <asp:Button ID="Button6" runat="server" Text="Logout" OnClick="Button6_Click" />
            




                <div class ="subject">

            <asp:GridView OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowDataBound="GridView1_RowDataBound" OnPageIndexChanging="OnPageIndexChangingstudents" ID="GridView1" runat="server"  CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="4" Width="432px">
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

            

            <asp:Button ID="Button9" runat="server" Text="Update" Width="96px" OnClick="Button3_Click" Height="29px" />
            <asp:Button ID="Button10" runat="server" Text="Delete" Width="96px" Height="29px" OnClick="Button2_Click" />

            <asp:Label ID="Label16" runat="server" Text="First Name:"></asp:Label>

            <asp:Label ID="Label17" runat="server" Text="Student ID:"></asp:Label>

            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

            <asp:Label ID="Label18" runat="server" Text="Last Name:"></asp:Label>

            <asp:TextBox ID="TextBox4" runat="server" Enabled="False"></asp:TextBox>

            



            <asp:Button ID="Button8" runat="server" Text="Add" Height="29px" Width="96px" OnClick="Button1_Click" />
            <asp:Button ID="Button7" runat="server" Text="Clear" Width="96px" Height="29px" OnClick="Button7_Click" />

            <asp:Label ID="Label15" runat="server" Text="User ID:"></asp:Label>

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <asp:Label ID="Label19" runat="server" Text="Year Level:"></asp:Label>

            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

            <asp:Label ID="Label20" runat="server" Text="Section:"></asp:Label>

                    <asp:DropDownList ID="DropDownList2" runat="server" Height="25px" Width="167px">
                        <asp:ListItem Value="0">Select Section</asp:ListItem>
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
            
            <asp:DropDownList ID="DropDownList3" runat="server" Height="25px">
                <asp:ListItem Value="0">Select S.Y</asp:ListItem>
                <asp:ListItem Value="1">2023-2024</asp:ListItem>
                <asp:ListItem Value="2">2024-2025</asp:ListItem>
                <asp:ListItem Value="3">2025-2026</asp:ListItem>
                <asp:ListItem Value="4">2026-2027</asp:ListItem>
                <asp:ListItem Value="5">2027-2028</asp:ListItem>
            </asp:DropDownList>
            
                    <asp:Button ID="Button11" runat="server" Text="Update" Width="96px" OnClick="Button3_Click" Height="29px" />
<asp:Button ID="Button12" runat="server" Text="Delete" Width="96px" Height="29px" OnClick="Button2_Click" />

<asp:Label ID="Label25" runat="server" Text="School Year:"></asp:Label>

                    


               

                

            

            

            </div>



            <div class ="sections">


                <asp:GridView OnRowDataBound="GridView2_RowDataBound" OnPageIndexChanging="OnPageIndexChangingsections" ID="GridView2" runat="server"  CellPadding="4" ForeColor="#333333" GridLines="None" AllowPaging="True" PageSize="4" Width="432px" Height="102px" OnSelectedIndexChanged="GridView2_SelectedIndexChanged">
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




            </div>


        
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
            
                    
        
    </form>   
    
</body>
</html>
