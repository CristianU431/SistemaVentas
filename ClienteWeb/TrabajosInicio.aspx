<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrabajosInicio.aspx.cs" Inherits="ClienteWeb.TrabajosInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <!-- Listar para la Tabla Trabajos -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
    <h3>Tabla Trabajos</h3>

    <p>
        <asp:GridView runat="server" class="table table-success table-striped" ID ="gvTrabajos"></asp:GridView>
    </p>

   
</asp:Content>
