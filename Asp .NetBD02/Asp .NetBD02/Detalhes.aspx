<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Detalhes.aspx.cs" Inherits="Asp.NetBD02.Detalhes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="text-center text-primary">
        <h2>Consutar Dados do Cliente</h2>

    </div>

    <div class="row" style="margin-top: 15px">

        <div class="col-md-2">
            <label>ID:</label>
            <asp:TextBox ID="txtID" runat="server" MaxLength="100" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div class="col-md-10">
            <label>Nome:</label>
            <asp:TextBox ID="txtNome" runat="server" MaxLength="100" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top: 15px">

        <div class="col-md-7">
            <label>Logradouro:</label>
            <asp:TextBox ID="txtLogradouro" runat="server" MaxLength="100" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div class="col-md-2">
            <label>Número:</label>
            <asp:TextBox ID="txtNumero" runat="server" MaxLength="5" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div class="col-md-3">
            <label>Complemento:</label>
            <asp:TextBox ID="txtComplemento" runat="server" MaxLength="10" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
    </div>

    <div class="row" style="margin-top: 15px">

        <div class ="col-md-5">
            <label>Bairro:</label>
            <asp:TextBox ID="txtBairro" runat="server" MaxLength="100" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div class="col-md-5">
            <label>Cidade:</label>
            <asp:TextBox ID="txtCidade" runat="server" MaxLength="100" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div class="col-md-2">
            <label>UF:</label>
            <asp:TextBox ID="textUf" runat="server" MaxLength="100" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>
    </div>

      <div class="row" style="margin-top: 15px">
          <div class="col-md-5">
              <label>Sexo:</label>
              <asp:TextBox ID="txtSexo" runat="server" MaxLength="9" CssClass ="form-control" Enabled="false"></asp:TextBox>
          </div>
      </div>



</asp:Content>
