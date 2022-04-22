<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="editCliente.aspx.cs" Inherits="WebApplication2.editCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">

                    <h4 class="card-title">Clientes</h4>

                    <hr />
                    <h5 class="card-title">Datos Cliente</h5>
                    <asp:HiddenField ID="hid" runat="server" />
                    <div class="row">
                        <div class="col-3">
                            <label>Apellido Paterno</label>
                            <asp:TextBox ID="txtap" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="col-3">
                            <label>Apellido Materno</label>
                            <asp:TextBox ID="txtam" runat="server" class="form-control"></asp:TextBox>
                        </div>

                        <div class="col-3">
                            <label>Nombre</label>
                            <asp:TextBox ID="txtNombre" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="col-3">
                            <label>Fecha Nacimiento</label>
                            <asp:TextBox ID="txtFNac" runat="server" class="form-control" type="Date"></asp:TextBox>
                        </div>


                    </div>


                    <hr />
                    <h5 class="card-title">Domicilio</h5>
                    <div class="row">
                        <div class="col-2">
                            <label>CP</label>
                            <asp:TextBox ID="txtcp" runat="server" class="form-control" AutoPostBack="true" OnTextChanged="txtcp_TextChanged"></asp:TextBox>
                        </div>
                        <div class="col-3">
                            <label>Colonia</label>
                            <asp:TextBox ID="txtCol" runat="server" class="form-control"></asp:TextBox>
                        </div>

                        <div class="col-3">
                            <label>Municipio</label>
                            <asp:TextBox ID="txtMun" runat="server" class="form-control"></asp:TextBox>
                        </div>

                        <div class="col-3">
                            <label>Estado</label>
                            <asp:TextBox ID="txtEdo" runat="server" class="form-control"></asp:TextBox>
                        </div>
                    </div>

                    <hr />
                    <h5 class="card-title">Contacto</h5>
                    <div class="row">
                        <div class="col-3">
                            <label>Tel. Domicilio</label>
                            <asp:TextBox ID="txtTel" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <div class="col-3">
                            <label>Celular</label>
                            <asp:TextBox ID="txtCel" runat="server" class="form-control"></asp:TextBox>
                        </div>

                        <div class="col-3">
                            <label>Correo Electonico</label>
                            <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
                        </div>


                    </div>

                    <br />
                    <div class="row">
                        <div class="col-2">
                            <asp:LinkButton ID="btnGuardar" runat="server" class="btn btn-info toastrDefaultSuccess" OnClick="btnGuardar_Click">Guardar</asp:LinkButton>
                        </div>
                    </div>


                </div>
            </div>
        </div>
    </div>

    


</asp:Content>
