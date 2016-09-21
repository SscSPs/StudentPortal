<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentPortal.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     
    <div class="jumbotron">
        <h1 id="s_portal">Students' Portal</h1>
        
        <p>&nbsp;</p>

        <p><label style="width:200px;">User Name</label>
            <asp:TextBox ID="Uname" runat="server"></asp:TextBox>
        </p>
      
        <p><label style="width:200px;">Password</label>
            <asp:TextBox ID="Pword" runat="server" OnTextChanged="Pword_TextChanged" TextMode="Password"></asp:TextBox>
        </p>
        <br />
        <p style ="margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button class="btn btn-default" ID="ButtLogin" runat="server" Text="Login" onclick="ButtLogin_Click" Width="179px" />&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; OR&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
<asp:Button class="btn btn-default" ID="ButtReg" runat="server" Text="Register" onclick="ButtReg_Click" Width="179px" />
        </p>
    </div>

</asp:Content>