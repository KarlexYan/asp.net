<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="testRecord.aspx.cs" Inherits="WebApplication1.testRecord" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>刷题记录</h1>
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
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True"  PageSize="5"  AutoGenerateColumns="False" OnPageIndexChanging="GridView1_PageIndexChanging" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" Width="792px">
        <Columns>
            <asp:BoundField DataField="QID" HeaderText="试题编号" ReadOnly="True">
            </asp:BoundField>
            <asp:BoundField DataField="content" HeaderText="题目" ReadOnly="True">
            </asp:BoundField>
            <asp:BoundField DataField="qoptions" HeaderText="选项" ReadOnly="True" />
            <asp:BoundField DataField="score" HeaderText="分值" ReadOnly="True" >
            </asp:BoundField>
            <asp:BoundField DataField="myanswer" HeaderText="我的答案" ReadOnly="false">
            <ControlStyle Width="30px" />
            </asp:BoundField>
            <asp:BoundField DataField="myScore" HeaderText="我的得分" ReadOnly="True">
            </asp:BoundField>
            <asp:BoundField DataField="testtime" HeaderText="答题时间" ReadOnly="True">
            </asp:BoundField>
            <asp:CommandField ButtonType="Button" EditText="重新作答" HeaderText="操作" InsertVisible="False" ShowEditButton="True" UpdateText="完成" ShowHeader="True" ItemStyle-Width="100px">
            </asp:CommandField>
        </Columns>
    </asp:GridView>
</asp:Content>
