<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="doExercise.aspx.cs" Inherits="CB20130106胡嘉希.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    <br />
    刷题页面
    <br />
    <br />
    <br />
    <div style="margin-left: 20px; margin-right: 20px; text-align: left;">
        <asp:Label ID="Label1" runat="server" Text="下列对学习理解正确的是()"></asp:Label>
        <br />
        <br />
        &nbsp;&nbsp;
        <asp:RadioButton GroupName="select" ID="RadioButton1" runat="server" AutoCheck="true" />
        <asp:Label ID="Label2" runat="server" Text="无能"></asp:Label>
        <br />
        &nbsp;&nbsp;
        <asp:RadioButton GroupName="select" ID="RadioButton2" runat="server" AutoCheck="true" />
        <asp:Label ID="Label3" runat="server" Text="无用"></asp:Label>
        <br />
        &nbsp;&nbsp;
        <asp:RadioButton GroupName="select" ID="RadioButton3" runat="server" AutoCheck="true" />
        <asp:Label ID="Label4" runat="server" Text="这里"></asp:Label>
        <br />
        &nbsp;&nbsp;
        <asp:RadioButton GroupName="select" ID="RadioButton4" runat="server" AutoCheck="true" />
        <asp:Label ID="Label5" runat="server" Text="靖妖魔舞"></asp:Label>
    </div>
    <br />
    <br />
    <br />

    <asp:Button ID="Button1" runat="server" OnClick="Submit_Click" Text="提交" />
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" OnClick="Next_Click" Text="下一题" />

</asp:Content>
