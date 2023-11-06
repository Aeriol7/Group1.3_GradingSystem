<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TeacherLoginPage.aspx.cs" Inherits="Group1._3_GradingSystem.TeacherPages.TeacherLoginPage" %>

<!DOCTYPE html>
<style type="text/css">
    #Panel1{
        position: fixed;
    }
    #Image1 {
        position: fixed;
        margin-right: 15px;
        margin-left: 15px;
        top: 14px;
        left: 12px;
        width: 58px;
        height: 58px;
    }
    #LoginDropDown {
        position: fixed;
        top: 35px;
        left: 1211px;
    }
    #Label1 {
        position: fixed;
        top: 20px;
        left: 105px;
    }
    #NavPanel {
        position: fixed;

    }
    #form1 {
        height: 604px;
    }
    .login-container {
        position: fixed;
        top: 110px;
        left: 134px;
        width: 1039px;
        height: 448px;
    }
    #TLoginFormPanel{
        position: fixed;
    }
    #LoginImage {
        position: fixed;
        height: 444px;
        width: 568px;
        top: 111px;
        left: 601px;
    }
    #HISIcon {
        position: fixed;
        top: 106px;
        left: 326px;
        height: 100px;
        width: 100px;
    }
    .HIS-label-container {
        position: fixed;
        top: 194px;
        left: 237px;
        width: 277px;
        height: 87px;
    }
    #HopeLabel {
        position: fixed;
        top: 204px;
        left: 249px;
    }
    #IntegratedLabel {
        position: fixed;
        top: 204px;
        left: 332px;
    }   
    #SchoolLabel {
        position: fixed;
        top: 244px;
        left: 315px;
        height: 31px;
        width: 115px;
    }
    .teacher-login-label {
        position: fixed;
        top: 293px;
        left: 227px;
        width: 297px;
        height: 34px;
    }
    #UserLoginLabel {
        position: fixed;
        top: 296px;
        left: 296px;
    }
    .teacher-login-form {
        position: fixed;
        top: 348px;
        left: 227px;
        width: 295px;
        height: 168px;
    }
    #txtUser {
        position: fixed;
        height: 27px;
        top: 349px;
        left: 228px;
    }
    #txtPass {
        position: fixed;
        top: 401px;
        left: 229px;
        height: 26px;
    }
    #btnLogin {
        position: fixed;
        top: 462px;
        left: 339px;
        width: 70px;
        height: 28px;
        bottom: 75px;
    }
    </style>

<form id="form1" runat="server">

<header style="height: 63px">
        <nav style="height: 66px">
            <asp:Image ID="Image1" img src="../imgs/HopeLogo_TransparentPng.png" runat="server" />
        <asp:Label ID="Label1" runat="server" Text="HOPE INTEGRATED SCHOOL" Font-Bold="False" Font-Size="16pt" Width="204px" Font-Names="Times New Roman"></asp:Label>

            <asp:DropDownList ID="LoginDropDown" runat="server">
                <asp:ListItem>Login</asp:ListItem>
                <asp:ListItem>Admin</asp:ListItem>
                <asp:ListItem>Teacher</asp:ListItem>
                <asp:ListItem>Student</asp:ListItem>
            </asp:DropDownList>

       </nav>
</header>
<head runat="server">
    <title></title>
</head>
<body style="height: 603px; width:1440px;"> 
        <div class="login-container">
            <asp:Panel ID="TLoginContainerPanel" runat="server" Height="447px" Width="1037px" BorderStyle="Solid" BorderWidth="1px">
            <asp:Panel ID="TLoginFormPanel" runat="server" Height="447px" Width="465px">
                <div class="HIS-label-container">
                    <asp:Label ID="IntegratedLabel" runat="server" Font-Names="Arial" Font-Size="20pt" ForeColor="#E85959">INTEGRATED</asp:Label>
                    <asp:Label ID="SchoolLabel" runat="server" Font-Names="Arial" Font-Size="20pt" ForeColor="#5FA1EF">SCHOOL</asp:Label>
                    <asp:Label ID="HopeLabel" runat="server" Font-Names="Arial" Font-Size="20pt" ForeColor="#EFF182">HOPE</asp:Label>
                </div>
                <div class="teacher-login-label">

                    <asp:Label ID="UserLoginLabel" runat="server" Font-Names="Arial" Font-Size="X-Large">Teacher Login</asp:Label>

                </div>
                <div class="teacher-login-form">

                    <asp:TextBox ID="txtUser" runat="server" Width="286px" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
                    <asp:TextBox ID="txtPass" runat="server" Width="286px" BorderStyle="Solid" BorderWidth="1px" TextMode="Password"></asp:TextBox>

                    <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click"  Text="Login" BackColor="#5FA1EF" Font-Names="Arial" Font-Size="Medium" ForeColor="White" />

                </div>
            </asp:Panel>
                <asp:Image ID="HISIcon" runat="server" img="" src="../imgs/HopeLogo_TransparentPng.png" />
                <asp:Image ID="LoginImage" img src="../imgs/FormGroup1Graphics.png"  runat="server" BorderStyle="Solid" BorderWidth="1px" Height="445px" />
                </asp:Panel>
        </div>
    </form>
</body>
