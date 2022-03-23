<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DescuentosBuscar.aspx.cs" Inherits="ClienteWeb.DescuentosBuscar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <!-- Buscar para la Tabla Descuentos -->
    <p> &nbsp;</p>
    <p> &nbsp;</p>
    
     <div class="card card-outline-secondary">
                        <div class="card-header">
                            <h3 class="mb-0">Buscar en la Tabla Descuentos</h3>
                        </div>
                        <div class="card-body">
                            <div autocomplete="off" class="form" role="form">
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Texto: </label>
                                    <div class="position-relative">
                                        
                                        <asp:TextBox runat="server" Id="txtTexto" class="form-control" type="text" placeholder="Ingrese Texto"/>
                                             <asp:RequiredFieldValidator ID="rfvTexto" runat="server" ControlToValidate="txtTexto" ErrorMessage="Texto Obligatorio" ValidationGroup="D">*</asp:RequiredFieldValidator>
    </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Criterio:</label>
                                    <div class="position-relative">
                                        <asp:TextBox runat="server" Id="txtCriterio" class="form-control" type="text" placeholder="Ingrese su criterio"/>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCriterio" ErrorMessage="Criterio Obligatorio" ValidationGroup="D">*</asp:RequiredFieldValidator>
          </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label"></label>
                                    <div class="position-relative">
                                       
                                       <asp:Button Text="Buscar" runat="server" Id="btnBuscar" ValidationGroup="D" OnClick="btnBuscar_Click" class="btn btn-primary" type="button" value="Buscar"/>
                                    </div>
                                </div>
                            </div>
                        </div>






    <p>
        <asp:GridView runat="server" ID ="gvDescuentos"></asp:GridView>
    </p>


</asp:Content>
