<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteStudents.aspx.cs" Inherits="AttendanceMonitoringSystem.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 119px;
        }
        .style2
        {
            width: 192px;
        }
        .style3
        {
            width: 96px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Delete Student Record</h2>
    
        <table style="width:100%;">
            <tr>
                <td class="style1">
                    <asp:Label ID="Label1" runat="server" Text="Input ID Number:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="input" runat="server" Width="180px"></asp:TextBox>
                </td>
                <td class="style3">
                    <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" 
                        style="margin-left: 0px" Text="Delete" Width="91px" />
                </td>
                <td>
                    <asp:Label ID="ex1" runat="server" Text="..."></asp:Label>
                </td>
            </tr>
        </table>
    
    <p>
        <asp:GridView ID="gv" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None" Width="678px">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>
    </p>
</asp:Content>
