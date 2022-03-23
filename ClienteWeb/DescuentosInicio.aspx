<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DescuentosInicio.aspx.cs" Inherits="ClienteWeb.DescuentosInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Listar para la Tabla Descuentos -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Descuentos</h3>

    <p>
        
        <asp:GridView runat="server" class="table table-success table-striped" ID ="gvDescuentos"></asp:GridView>
    </p>

</asp:Content>
