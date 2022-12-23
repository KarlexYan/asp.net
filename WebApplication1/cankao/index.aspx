<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CB20130106胡嘉希.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    错题排行
    <br />
    <br />

    <asp:GridView ID="GridView1" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510"></FooterStyle>

        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White"></HeaderStyle>

        <PagerStyle HorizontalAlign="Center" ForeColor="#8C4510"></PagerStyle>

        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510"></RowStyle>

        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White"></SelectedRowStyle>

        <SortedAscendingCellStyle BackColor="#FFF1D4"></SortedAscendingCellStyle>

        <SortedAscendingHeaderStyle BackColor="#B95C30"></SortedAscendingHeaderStyle>

        <SortedDescendingCellStyle BackColor="#F1E5CE"></SortedDescendingCellStyle>

        <SortedDescendingHeaderStyle BackColor="#93451F"></SortedDescendingHeaderStyle>
    </asp:GridView>
</asp:Content>
