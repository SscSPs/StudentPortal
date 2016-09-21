<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="attendance.aspx.cs" Inherits="StudentPortal.attandance" Async="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <fieldset><div><p> 
        <asp:DropDownList Width ="100px" ID="Batch" runat="server"  OnTextChanged="Batch_SelectedIndexChanged" AutoPostBack ="true">
        </asp:DropDownList>
        </p>
        <p> 
            <asp:DropDownList Width="100px" ID="Subject" runat="server">
            </asp:DropDownList>
        </p>
        <asp:Panel ID="Panel1" runat="server">
        </asp:Panel>
        </div>
        </fieldset>
</asp:Content>
