<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="AttendanceMonitoringSystem.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>
        Student data maintenance</h2>
    <p>
        <asp:Button ID="btnView" runat="server" Text="View Student Record" onclick="btnView_Click" 
            Width="180px" BackColor="#506272" BorderColor="#506272" ForeColor="#C9CED5" />
    </p>
    <p>
        <asp:Button ID="btnAdd" runat="server" Text="Add Student" onclick="btnAdd_Click" 
            Width="180px" BackColor="#506272" BorderColor="#506272" ForeColor="#C9CED5" />
    </p>
    <p>
        <asp:Button ID="btnDel" runat="server" Text="Delete Student" onclick="btnDel_Click" 
            Width="180px" BackColor="#506272" BorderColor="#506272" ForeColor="#C9CED5" />
    </p>
    <p>
    </p>
</asp:Content>
