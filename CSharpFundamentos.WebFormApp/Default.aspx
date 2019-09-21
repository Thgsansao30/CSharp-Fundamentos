<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CSharpFundamentos.WebFormApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
    <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
    <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnSalvar" runat="server" Text="Criar" OnClick="btnSalvar_Click" />
</asp:Content>
