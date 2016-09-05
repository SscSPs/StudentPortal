<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentPortal._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome to Students Protal</h1>
        <p class="lead">This is a free portal where anyone can track their college records, like Attendance, Marks, Assignments, etc. Also, we provide you with a record of all the activities you perform here.</p>
        <p><a href="/About.aspx" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                First thing you need to do is Login with your college ID and Password provided to you be your college. There you will see all you can do as provided by your college.</p>
            <p>
                <a class="btn btn-default" href="http://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <p>
            Made by Sahil, Ananay and Chaitanay as a Level 2 project for MSITA.
        <p>
    </div>

</asp:Content>
