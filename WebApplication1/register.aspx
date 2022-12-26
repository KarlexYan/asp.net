<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WebApplication1.register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <h1>注册页</h1>
    <table>
        <tr>
            <td style="width:50%">用户名：</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
        </tr>
        <tr>
            <td style="width:50%">密码：</td>
            <td><asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">姓名：</td>
            <td><asp:TextBox ID="TextBox3" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">性别：</td>
            <td><asp:TextBox ID="TextBox4" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">学校：</td>
            <td><asp:TextBox ID="TextBox5" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">生日：</td>
            <td><asp:TextBox ID="TextBox6" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">电话：</td>
            <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">E-Mail：</td>
            <td><asp:TextBox ID="TextBox8" runat="server" ></asp:TextBox></td>
        </tr>
        <tr>
            <td style="width:50%">
                <br />
                <br />
                <asp:Button ID="btnRegister" Width="80px" runat="server" Text="注册" Height="20px" OnClick="btnRegister_Click" /></td>
            <td>
                <br />
                <br />
                <asp:Button ID="btnCancel" Width="80px" runat="server" Text="取消" Height="20px" OnClick="btnCancel_Click"  />&nbsp;&nbsp</td>
        </tr>
    </table>
</asp:Content>
