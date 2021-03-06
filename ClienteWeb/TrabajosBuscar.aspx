<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrabajosBuscar.aspx.cs" Inherits="ClienteWeb.TrabajosBuscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <!-- Buscar para la Tabla Trabajos -->
    <p> &nbsp;</p>
    <p> &nbsp;</p>


     <div class="card card-outline-secondary">
                        <div class="card-header">
                            <h3 class="mb-0">Buscar en la Tabla Trabajos</h3>
                        </div>
                        <div class="card-body">
                            <div autocomplete="off" class="form" role="form">
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Texto: </label>
                                    <div class="col-lg-9">
                                        
                                        <asp:TextBox runat="server" Id="txtTexto" class="form-control" type="text" placeholder="Ingrese Texto"/>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTexto" ErrorMessage="Texto Obligatorio" ValidationGroup="D">*</asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Criterio:</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtCriterio" class="form-control" type="text" placeholder="Ingrese su criterio"/>
                                            <asp:RequiredFieldValidator ID="rfvCriterio" runat="server" ControlToValidate="txtCriterio" ErrorMessage="Criterio Obligatorio" ValidationGroup="D">*</asp:RequiredFieldValidator>
                                     </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label"></label>
                                    <div class="col-lg-9">
                                       
                                        <asp:Button Text="Buscar" runat="server" Id="btnBuscar" ValidationGroup="D" OnClick="btnBuscar_Click" class="btn btn-primary" type="button" value="Buscar"/>
                                    </div>
                                </div>
                            </div>
                        </div>



   
    <p>
        <asp:GridView runat="server" ID ="gvTrabajos"></asp:GridView>
    </p>


</asp:Content>
