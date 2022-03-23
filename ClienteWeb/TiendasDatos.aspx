<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TiendasDatos.aspx.cs" Inherits="ClienteWeb.TiendasDatos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <!-- Formulario del CRUD para la tabla Tienda -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
  
       <div class="card card-outline-secondary">
                        <div class="card-header">
                            <h3 class="mb-0">CRUD de la tabla Tienda</h3>
                        </div>
                        <div class="card-body">
                            <div autocomplete="off" class="form" role="form">
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Id: </label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtId" class="form-control" type="text" placeholder="Ingrese Id"/>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="Id Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtId" ErrorMessage="Id Obligatorio" ValidationGroup="B">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtId" ErrorMessage="Id Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>

                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Nombre de la Tienda:</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtNombre" class="form-control" type="text" placeholder="Ingrese Nombre de la Tienda"/>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtNombre" ErrorMessage="Nombre Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNombre" ErrorMessage="Nombre Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>

                                            </div>
                                </div>
                            <div autocomplete="off" class="form" role="form">
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Direccion de la Tienda: </label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtDireccion" class="form-control" type="text" placeholder="Ingrese Direccion de la Tienda"/>
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Direccion Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Direccion Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>



                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Ciudad:</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtCiudad" class="form-control" type="text" placeholder="Ingrese Ciudad"/>
                                             <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtCiudad" ErrorMessage="Ciudad Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtCiudad" ErrorMessage="Ciudad Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>

                                    </div>
                                </div>
															<div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Estado: </label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtEstado" class="form-control" type="text" placeholder="Ingrese Estado"/>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtCodPostal" ErrorMessage="Codigo Postal Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtCodPostal" ErrorMessage="Codigo Postal Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>

                                    </div>
                                </div>
															<div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Codigo Postal:  </label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtCodPostal" class="form-control" type="text" placeholder="Ingrese Codigo Postal"/>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtCodPostal" ErrorMessage="Codigo Postal Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtCodPostal" ErrorMessage="Codigo Postal Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>

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
        <asp:GridView runat="server" ID ="gvTiendas"></asp:GridView>
    </p>

     <asp:ValidationSummary ID="ValidationSummary5" runat="server" ShowMessageBox="True" ValidationGroup="C" />
     <asp:ValidationSummary ID="ValidationSummary4" runat="server" ShowMessageBox="True" ValidationGroup="B" />
     <asp:ValidationSummary ID="ValidationSummary3" runat="server" ShowMessageBox="True" ValidationGroup="A" />



</asp:Content>
