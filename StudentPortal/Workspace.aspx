<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Workspace.aspx.cs" Inherits="StudentPortal.Workspace" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="work_details">
        <br />
    <asp:Label ID="Label1" runat="server" Text="Attendance: "></asp:Label>
    <asp:Label ID="Label2" runat="server" Text="85%"></asp:Label><br /><br />
    <asp:Label ID="Label3" runat="server" Text="SGPA: "></asp:Label><asp:Label ID="Label4" runat="server" Text="8.23"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="New Request" Width="246px" Height="29px" OnClick="Button1_Click" />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Width="240px" placeholder="Enter Subject" Height="22px"></asp:TextBox>
        <br />
        <br />
        <textarea id="TextArea1" runat="server" name="S1" placeholder="Enter Description"></textarea><br />
        <br />
        <asp:Button ID="Button2" runat="server" Height="29px" OnClick="Button2_Click" Text="Submit" Width="245px" />
        <br />
        <br />
        </div>
</asp:Content>
