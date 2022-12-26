<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication1.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h1>注册页</h1>
    <center>
        <asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="Label2" runat="server" Text="密  码："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br /><br /><br />
        <asp:Button ID="Button1" runat="server" Text="登录" OnClick="Button1_Click" />
        &nbsp;
        <asp:Button ID="Button2" runat="server" Text="返回" OnClick="Button2_Click"/>
    </center>
</asp:Content>
