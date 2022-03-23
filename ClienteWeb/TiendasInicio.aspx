<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TiendasInicio.aspx.cs" Inherits="ClienteWeb.TiendasInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <!-- Listar para la Tabla Tienda -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Tienda</h3>

    <p>
        <asp:GridView runat="server"  class="table table-success table-striped" ID ="gvTiendas"></asp:GridView>
        
    </p>

</asp:Content>
