<%@ Page Title="Hello World" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="WebApp.SamplePages.FirstPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    Enter your name<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
    &nbsp;&nbsp;
    <asp:Button ID="PressMe" runat="server" Text="Press Me" OnClick="PressMe_Click" />
    <br />
    <asp:Literal ID="OutputMessage" runat="server"></asp:Literal>
</asp:Content>
