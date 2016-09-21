<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="StudentPortal.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class ="reg_form">
<label id="l1">First Name</label><asp:TextBox ID="Reg_inp_fname" runat="server" ValidateRequestMode="Enabled">
</asp:TextBox><asp:RequiredFieldValidator id="RequiredFieldValidator1" runat="server"
  ControlToValidate="Reg_inp_fname"
  ErrorMessage="First name is a required field."
  ForeColor="Darkgray"
    class="validation">
</asp:RequiredFieldValidator>
    <br />
    <br />


    <label id="l2">Last Name</label><asp:TextBox ID="Reg_inp_lname" runat="server" ValidateRequestMode="Enabled"></asp:TextBox>
    <asp:RequiredFieldValidator id="RequiredFieldValidator2" runat="server"
  ControlToValidate="Reg_inp_lname"
  ErrorMessage="Last name is a required field."
  ForeColor="Darkgray"
        class="validation">
</asp:RequiredFieldValidator>
    <br />
    <br />


    <label id="l3">Roll Number</label><asp:TextBox ID="Reg_inp_Rollnumber" runat="server" MaxLength="10" ValidateRequestMode="Enabled"></asp:TextBox>
    <asp:RequiredFieldValidator id="RequiredFieldValidator3" runat="server"
  ControlToValidate="Reg_inp_Rollnumber"
  ErrorMessage="Roll Number is a required field."
  ForeColor="Darkgray"
        class="validation">
</asp:RequiredFieldValidator>
    <br />
    <br />


    <label id="l4">Email</label><asp:TextBox ID="Reg_inp_email" runat="server" TextMode="Email" ValidateRequestMode="Enabled"></asp:TextBox>
    <asp:RequiredFieldValidator id="RequiredFieldValidator4" runat="server"
  ControlToValidate="Reg_inp_email"
  ErrorMessage="Email is a required field."
  ForeColor="Darkgray"
        class="validation">
</asp:RequiredFieldValidator>
    <br />
    <br />


    <label id="l5">Password</label><asp:TextBox ID="Reg_inp_pass1" runat="server" TextMode="Password" ValidateRequestMode="Enabled"></asp:TextBox>
    <asp:RequiredFieldValidator id="RequiredFieldValidator5" runat="server"
  ControlToValidate="Reg_inp_pass1"
  ErrorMessage="Password is a required field."
  ForeColor="Darkgray"
        class="validation">
</asp:RequiredFieldValidator>
    <br />
    <br />


    <label>Confirm Password</label><asp:TextBox ID="Reg_inp_pass2" runat="server" TextMode="Password" ValidateRequestMode="Enabled"></asp:TextBox>
    <asp:RequiredFieldValidator id="RequiredFieldValidator6" runat="server"
  ControlToValidate="Reg_inp_pass2"
  ErrorMessage=" Confirm Password"
  ForeColor="Darkgray"
        class="validation">
</asp:RequiredFieldValidator>
    <br />
    <br />
        <br />
        
    


    <asp:Button ID="Button1" class="btn btn-default" runat="server" Text="Register" OnClick ="ButtRegis_click" Width="186px" />
    </div>

    </asp:Content>

