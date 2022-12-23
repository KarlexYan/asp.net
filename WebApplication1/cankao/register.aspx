<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="CB20130106胡嘉希.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div style="height: 200px;">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <asp:Label ID="Label3" runat="server" Text="昵称："></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Width="112px"></asp:TextBox>

        <br />

        <asp:Label ID="Label1" runat="server" Text="学号："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Width="112px"></asp:TextBox>

        <br />
        
        <asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="112px" TextMode="Password"></asp:TextBox>
        
        <br />
        <br />

        <asp:Button ID="Button1" runat="server" OnClick="Enroll_Click" Text="注册" />
        
    </div>

</asp:Content>
