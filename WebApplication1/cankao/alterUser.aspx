<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="alterUser.aspx.cs" Inherits="CB20130106胡嘉希.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    修改个人信息
    <br />
    <br />
    <br />
    <div style="margin-left: 40px; margin-right: 40px; text-align: left;">

        <asp:Label runat="server" Text="昵称："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="112px"></asp:TextBox>
        <br />
        <br />
        <asp:Label runat="server" Text="性别："></asp:Label>
        &nbsp;&nbsp;
        <asp:RadioButton GroupName="select" ID="RadioButton1" runat="server" AutoCheck="true" Checked="True" />男
        &nbsp;&nbsp;
        <asp:RadioButton GroupName="select" ID="RadioButton2" runat="server" AutoCheck="true" />女
    <br />
        <br />
        <asp:Label runat="server" Text="年龄："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Number" Width="112px"></asp:TextBox>

        <br />
        <br />
        <br />

        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Submit_Click" Text="提交" />
    </div>
</asp:Content>
