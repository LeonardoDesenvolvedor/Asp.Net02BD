<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="Asp.NetBD02.editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

     <link rel="stylesheet" type="text/css"
      href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css" />

    <script src="Scripts/jquery-3.0.0.min.js"></script>

    <link rel="stylesheet" type="text/css"
      href="https://cdn.datatables.net/1.10.24/css/jquery.dataTables.min.css" />

    <script src="https://cdn.datatables.net/1.10.24/js/jquery.dataTables.min.js"></script>

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center text-primary">
        <h2>Editar Dados Dos Cliente</h2>
    </div>

    <div class="row" style="margin-top: 15px">
        <div class="col-md-2">
            <label>ID:</label>
            <asp:TextBox ID="txtId" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div class="col-md-10">
            <lable>Nome:</lable>
            <asp:TextBox ID="txtNome" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top: 15px">

        <div class="col-md-7">
            <label>Logradouro:</label>
            <asp:TextBox ID="txtLogradouro" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="col-md-2">
            <label>Número:</label>
            <asp:TextBox ID="txtNumero" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>

        </div>

        <div class="col-md-3">
            <label>Complemento:</label>
            <asp:TextBox ID="txtComplemento" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top: 15px">

        <div class="col-md-5">
            <label>Bairro:</label>
            <asp:TextBox ID="txtBairro" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="col-md-5">
            <label>Cidade:</label>
            <asp:TextBox ID="txtCidade" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="col-md-2">
            <label>UF:</label>
            <asp:TextBox ID="txtUf" runat="server" MaxLength="100" CssClass="form-control"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top: 15px">

        <div class="col-md-4">
            <label>Sexo:</label>
            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control">
                <asp:ListItem Value=""></asp:ListItem>
                <asp:ListItem Value="F">Feminino</asp:ListItem>
                <asp:ListItem Value="M">Masculino</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>


     <div class="row" style="margin-top: 15px">
        <div class="col-md-5 text-right">
            <asp:Button ID="btnCancelar" CssClass="btn btn-warning" runat="server" Text="CANCELAR" OnClick="btnCancelar_Click" />
        </div>
     <nb&p></nb>

        <div class="col-md-5 text-right">
            <asp:Button ID="btnAlterar" CssClass="btn btn-warning" runat="server" Text="ALTERAR" OnClick="btnAlterar_Click"/>
        </div>
    </div>

    <div class="row" style="margin-top: 15px">
        <div class="col-md-12 text-right">
            <asp:Label ID="lblResultado" CssClass="text-success" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>



