<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Workspace.aspx.cs" Inherits="StudentPortal.Workspace" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <br />
        <h1>Welcome</h1>
        </header>
                <hr />
            
    <div id="work_details">
        <asp:Label ID="Label1" runat="server" Text="Attendance: "></asp:Label>
        <asp:Label ID="Label2" runat="server"></asp:Label><br /><br />
        <asp:Label ID="Label3" runat="server" Text="SGPA: "></asp:Label><asp:Label ID="Label4" runat="server" Text="8.23"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="New Request" Width="253px" Height="26px" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="248px" Height="16px" placeholder="Enter Subject"></asp:TextBox>
        <br />
        <br />
        <asp:TextBox id="TextBox2" runat="server" TextMode="MultiLine" placeholder="Enter Description"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Submit" Width="253px" Height="27px" OnClick="Button2_Click" />
        <br />
        <br />
    </div>
</asp:Content>
