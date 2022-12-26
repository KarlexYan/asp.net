<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WebApplication1.homepage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>个人资料页</h1>
    <table>
        <tr>
            <td style="width:50%">用户名：</td>
            <td>
                <asp:Label ID="Label1" runat="server" Text="" ></asp:Label></td>
        </tr>
        <tr>
            <td style="width:50%">密码：</td>
            <td><asp:TextBox ID="TextBox2" runat="server" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">姓名：</td>
            <td><asp:TextBox ID="TextBox3" runat="server" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">性别：</td>
            <td><asp:TextBox ID="TextBox4" runat="server" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">学校：</td>
            <td><asp:TextBox ID="TextBox5" runat="server" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">生日：</td>
            <td><asp:TextBox ID="TextBox6" runat="server" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">电话：</td>
            <td><asp:TextBox ID="TextBox7" runat="server" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">E-Mail：</td>
            <td><asp:TextBox ID="TextBox8" runat="server" ReadOnly="true"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">
                <br />
                <br />
                <asp:Button ID="btnFinish" Width="80px" runat="server" Text="完成" Height="20px" Visible="False" OnClick="btnFinish_Click" /></td>
            <td>
                <br />
                <br />
                <asp:Button ID="btnModify" Width="80px" runat="server" Text="修改" Height="20px" OnClick="btnModify_Click" />&nbsp;&nbsp;<asp:Button ID="btnCancel" Width="80px" runat="server" Text="取消" Height="20px" Visible="False" OnClick="btnCancel_Click" /></td>
        </tr>
    </table>
</asp:Content>
