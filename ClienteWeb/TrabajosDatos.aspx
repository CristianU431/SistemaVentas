<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TrabajosDatos.aspx.cs" Inherits="ClienteWeb.TrabajosModificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <!-- Formulario del CRUD para la tabla Trabajos -->
    <h3>&nbsp;</h3>
    <p>&nbsp;</p>
     <div class="card card-outline-secondary">
                        <div class="card-header">
                            <h3 class="mb-0">CRUD de la tabla Trabajos</h3>
                        </div>
                        <div class="card-body">
                            <div autocomplete="off" class="form" role="form">
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Id: </label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtId" class="form-control" type="text" placeholder="Ingrese Id"/>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="Id Obligatorio" ValidationGroup="B">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtId" ErrorMessage="Id Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>

                                    </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Descripcion de Trabajo:</label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtDescripcion" class="form-control" type="text" placeholder="Ingrese Nombre de la Tienda"/>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Descripcion de Trabajo Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Descripcion de Trabajo Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>

                                            </div>
                                </div>
                            <div autocomplete="off" class="form" role="form">
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Nivel minimo de Trabajadores: </label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtmin" class="form-control" type="text" placeholder="Ingrese Direccion de la Tienda"/>
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtmax" ErrorMessage="Nivel maximo de Trabajadores Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtmax" ErrorMessage="Nivel maximo de Trabajadores Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>

                                            </div>
                                </div>
                                <div class="form-group row">
                                    <label class="col-lg-3 col-form-label form-control-label">Nivel maximo de Trabajadores: </label>
                                    <div class="col-lg-9">
                                        <asp:TextBox runat="server" Id="txtmax" class="form-control" type="text" placeholder="Ingrese Ciudad"/>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtmax" ErrorMessage="Nivel maximo de Trabajadores Obligatorio" ValidationGroup="A">*</asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtmax" ErrorMessage="Nivel maximo de Trabajadores Obligatorio" ValidationGroup="C">*</asp:RequiredFieldValidator>
 
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
        <asp:GridView runat="server" ID ="gvTrabajadores"></asp:GridView>
    </p>

     <asp:ValidationSummary ID="ValidationSummary5" runat="server" ShowMessageBox="True" ValidationGroup="C" />
     <asp:ValidationSummary ID="ValidationSummary4" runat="server" ShowMessageBox="True" ValidationGroup="B" />
     <asp:ValidationSummary ID="ValidationSummary3" runat="server" ShowMessageBox="True" ValidationGroup="A" />


</asp:Content>
