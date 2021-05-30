<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="TesteBD.aspx.cs" Inherits="Asp.NetBD02.TesteBD" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="text-center">
        <asp:Button ID="btnTestar" runat="server" CssClass="btn btn-primary" Text="TESTAR Conexão com BD" OnClick="btnTestar_Click"/>

        <br />
        <asp:Label ID="lblResultado" runat="server" CssClass="text-capitalize"></asp:Label>
    </div>

</asp:Content>
