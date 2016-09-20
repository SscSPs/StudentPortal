<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentPortal.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     
    <div class="jumbotron">
        <h1>Login to Students Portal</h1>
        <p class="lead">Enter Your credentials below</p>
        <p>&nbsp;</p>

        <p><label style="width:200px;">User Name</label>
            <asp:TextBox ID="Uname" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="Uname"
                    ErrorMessage="Username is a required field."
                    ForeColor="Darkgray"
                    class="validation">
                </asp:RequiredFieldValidator>
            
        </p>
      
        <p><label style="width:200px;">Password</label>
            <asp:TextBox ID="Pword" runat="server" OnTextChanged="Pword_TextChanged" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
                ControlToValidate="Pword"
                ErrorMessage="Password is a required field."
                ForeColor="Darkgray"
                class="validation">
            </asp:RequiredFieldValidator>
        </p>
        <p style ="margin-top:10px;">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button class="btn btn-default" ID="ButtLogin" runat="server" Text="Login" onclick="ButtLogin_Click" Width="179px" />&nbsp;&nbsp;<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; OR&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
<asp:Button class="btn btn-default" ID="ButtReg" runat="server" Text="Register" onclick="ButtReg_Click" Width="179px" />
        </p>
    </div>

</asp:Content>