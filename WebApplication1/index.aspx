<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebApplication1.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>欢迎来到刷题网站</h1><br />
    <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click"/>
    &nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="注册" OnClick="Button2_Click" />
</asp:Content>
