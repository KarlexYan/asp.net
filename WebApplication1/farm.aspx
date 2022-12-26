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
            <asp:ListItem Value="1">数一</asp:ListItem>
            <asp:ListItem Value="2">英语一</asp:ListItem>
            <asp:ListItem Value="3">政治</asp:ListItem>
            <asp:ListItem Value="4">计算机学科专业基础</asp:ListItem>
            <asp:ListItem Value="5">数学二</asp:ListItem>
            <asp:ListItem Value="6">英语二</asp:ListItem>
            <asp:ListItem Value="7">C语言</asp:ListItem>
            <asp:ListItem Value="8">数据库</asp:ListItem>
            <asp:ListItem Value="9">数据结构</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:Label ID="Label3" runat="server" Text="年份："></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Width="46px"></asp:TextBox>
        &nbsp;
        <asp:Button ID="Button1" runat="server"  Text="搜索" Width="49px" OnClick="Button1_Click"/>
    </p>
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True"  PageSize="5"  AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating">
        <Columns>
            <asp:BoundField DataField="QID" HeaderText="试题编号" ReadOnly="True" ItemStyle-Width="70px" >
<ItemStyle Width="70px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="content" HeaderText="题目" ReadOnly="True" ItemStyle-Width="250px" >
<ItemStyle Width="250px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="qoptions" HeaderText="选项" ReadOnly="True" />
            <asp:BoundField DataField="score" HeaderText="分值" ReadOnly="True" ItemStyle-Width="20px">
<ItemStyle Width="20px"></ItemStyle>
            </asp:BoundField>
            <asp:BoundField DataField="myanswer" HeaderText="我的答案" ReadOnly="false" ItemStyle-Width="50px">
            <ControlStyle Width="40px" />
<ItemStyle Width="50px"></ItemStyle>
            </asp:BoundField>
            <asp:CommandField ButtonType="Button" EditText="开始作答" HeaderText="操作" InsertVisible="False" ShowEditButton="True" UpdateText="完成答题" ShowHeader="True" ItemStyle-Width="120px" >
<ItemStyle Width="120px"></ItemStyle>
            </asp:CommandField>
        </Columns>
    </asp:GridView>
</asp:Content>
