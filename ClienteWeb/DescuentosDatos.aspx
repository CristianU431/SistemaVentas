<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DescuentosDatos.aspx.cs" Inherits="ClienteWeb.DescuentosDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <!-- Formulario del CRUD para la tabla Descuentos -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>

      <div class="card card-outline-secondary">
                        <div class="card-header">
                            <h3 class="mb-0">CRUD de la tabla Descuentos</h3>
                        </div>
                        <div class="card-body">
                            <div autocomplete="off" class="form" role="form">
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Tipo de Descuento: </label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtTipoDescuento" class="form-control" type="text" placeholder="Ingrese Texto"/>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTipoDescuento" ErrorMessage="Tipo de Descuento Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTipoDescuento" ErrorMessage="Tipo de Descuento Obligatorio" ValidationGroup="B">*</asp:RequiredFieldValidator>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTipoDescuento" ErrorMessage="Tipo de Descuento Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Id de la Tienda:</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtIdTienda" class="form-control" type="text" placeholder="Ingrese su criterio"/>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtIdTienda" ErrorMessage="Id de la Tienda Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtIdTienda" ErrorMessage="Id de la Tienda Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            <div autocomplete="off" class="form" role="form">
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Tamaño minimas: </label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtTamMin" class="form-control" type="text" placeholder="Ingrese minimas"/>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtTamMin" ErrorMessage="Tamaño minimas Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtTamMin" ErrorMessage="Tamaño minimas Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Tamaño maximas:</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtTamMax" class="form-control" type="text" placeholder="Ingrese maximas"/>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtTamMax" ErrorMessage="Tamaño maximas Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtTamMax" ErrorMessage="Tamaño maximas Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>
                                    </div>
                                </div>
															<div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Descuento: </label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtDescuento" class="form-control" type="text" placeholder="Ingrese descuento"/>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtDescuento" ErrorMessage="Descuento Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtDescuento" ErrorMessage="Descuento Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>
                                    </div>
                                </div>
															 <hr>
                                 <div class="form-group row">
                                    <div class="col-3">
                                        <button class="btn btn-info btn-lg btn-block" type="Info">Agregar</button>
																			
                                    </div>
                                    <div class="col-3">
                                        <button class="btn btn-danger btn-lg btn-block" type="submit">Eliminar</button>
                                    </div>
																	 <div class="col-3">
                                        <button class="btn btn-success btn-lg btn-block" type="submit">Actualizar</button>
                                    </div>
                                </div>
                            </div>
                        </div>





    <p>
        <asp:GridView runat="server" ID ="gvDescuentos"></asp:GridView>
    </p>

     <asp:ValidationSummary ID="ValidationSummary5" runat="server" ShowMessageBox="True" ValidationGroup="C" />
     <asp:ValidationSummary ID="ValidationSummary4" runat="server" ShowMessageBox="True" ValidationGroup="B" />
     <asp:ValidationSummary ID="ValidationSummary3" runat="server" ShowMessageBox="True" ValidationGroup="A" />


</asp:Content>
