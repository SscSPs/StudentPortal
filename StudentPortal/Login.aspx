<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentPortal.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     
    <div class="jumbotron">
        <h1>Login to Students Protal</h1>
        <p class="lead">Enter Your credentials below</p>
        <p>&nbsp;</p>
        <p>User Name:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Uname" runat="server"></asp:TextBox>
        </p>
        <p>Password:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Pword" runat="server" OnTextChanged="Pword_TextChanged" TextMode="Password"></asp:TextBox>
        </p>
        <p style="margin-left: 160px">
&nbsp;
<asp:Button class="btn btn-default" ID="ButtLogin" runat="server" Text="Login" onclick="ButtLogin_Click" /></p>
    </div>

</asp:Content>