<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="allPaper.aspx.cs" Inherits="WebApplication1.allPaper" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>试题列表</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="学校："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label2" runat="server" Text="科目："></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
&nbsp;<asp:Label ID="Label3" runat="server" Text="年份："></asp:Label>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="搜索" Width="49px" />
    </p>
   
</asp:Content>
