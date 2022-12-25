<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="farm.aspx.cs" Inherits="WebApplication1.farm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>刷题模块</h1>
    <p>
        <asp:Label ID="Label1" runat="server" Text="学校："></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;<asp:Label ID="Label2" runat="server" Text="科目："></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
&nbsp;<asp:Label ID="Label3" runat="server" Text="年份："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="46px"></asp:TextBox>
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="搜索" Width="49px" />
    </p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="true"  PageSize="5" Width="70%" AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging">
        <Columns>
            <asp:BoundField DataField="QID" HeaderText="试题编号" ReadOnly="True" />
            <asp:BoundField DataField="content" HeaderText="题目" ReadOnly="True" />
            <asp:BoundField DataField="qoptions" HeaderText="选项" ReadOnly="True" />
            <asp:BoundField DataField="score" HeaderText="分值" ReadOnly="True" />
            <asp:BoundField DataField="myanswer" HeaderText="我的答案" ReadOnly="True" />
        </Columns>
    </asp:GridView>
</asp:Content>
