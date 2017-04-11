<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddStudents.aspx.cs" Inherits="AttendanceMonitoringSystem.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">

        .style1
        {
            width: 147px;
            text-align: right;
        }
        .style2
        {
            width: 266px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <h2>
        Create Student Data</h2>
        <table style="width:100%;">
            <tr>
                <td class="style1">
                    ID Number</td>
                <td class="style2">
                    <asp:TextBox ID="id" runat="server" Width="259px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="ex1" runat="server" Text="..."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Given Name</td>
                <td class="style2">
                    <asp:TextBox ID="gname" runat="server" Width="259px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="ex2" runat="server" Text="..."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Middle Name</td>
                <td class="style2">
                    <asp:TextBox ID="mname" runat="server" Width="259px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="ex3" runat="server" Text="..."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    Last Name</td>
                <td class="style2">
                    <asp:TextBox ID="lname" runat="server" Width="259px"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="ex4" runat="server" Text="..."></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style1">
                    </td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Button ID="btnAdd" runat="server" Text="Add Student" Width="262px" 
                        onclick="btnAdd_Click" />
                </td>
                <td>
                    <asp:Label ID="ex5" runat="server" Text="..."></asp:Label>
                </td>
            </tr>
        </table>

        </asp:Content>
