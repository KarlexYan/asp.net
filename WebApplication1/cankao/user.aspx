<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="user.aspx.cs" Inherits="CB20130106胡嘉希.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    用户信息
    <br />
    <br />
    <br />
    <div  style="margin-left: 40px; margin-right: 40px; text-align: left;">
        
        <asp:Label  runat="server" Text="昵称："></asp:Label>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br />
        <asp:Label  runat="server" Text="账号："></asp:Label>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <br />
        <asp:Label  runat="server" Text="性别："></asp:Label>
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    <br />
        <asp:Label  runat="server" Text="年龄："></asp:Label>
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    </div>
        <br />
        <br />
        <br />
        <br />

        <asp:Button ID="Button1" runat="server" OnClick="Amend_Click" Text="修改" />
</asp:Content>
