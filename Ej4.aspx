<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ej4.aspx.cs" Inherits="WebApplication2.Ej4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-md-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">

                    <h4 class="card-title">Clientes</h4>

                    <div class="row">
                        <div class="col-3">
                            <div class="form-group row">
                                <label class="col-sm-5 col-form-label" style="text-align: right;">Nombre:</label>
                                <div class="col-sm-7">
                                    <asp:TextBox ID="txtNombre" runat="server" class="form-control" TextMode="Search"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-3">
                            <div class="form-group row">
                                <label class="col-sm-5 col-form-label" style="text-align: right;">Paterno:</label>
                                <div class="col-sm-7">
                                    <asp:TextBox ID="txtAp" runat="server" class="form-control" TextMode="Search"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="col-3">
                            <div class="form-group row">
                                <label class="col-sm-5 col-form-label" style="text-align: right;">f. Nac.:</label>
                                <div class="col-sm-7">
                                    <asp:TextBox ID="txtfNac" runat="server" class="form-control" TextMode="Search"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="col-1">
                            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" class="btn btn-primary mr-2" OnClick="btnBuscar_Click" />
                        </div>

                        <div class="col-1">
                            <asp:LinkButton ID="btnNuevo" runat="server" class="btn btn-info" OnClick="btnNuevo_Click">Nuevo</asp:LinkButton>

                        </div>

                    </div>

                    <div class="row">
                        <div class="col-12">
                            <asp:GridView ID="GridView1" runat="server" class="table table-bordered" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"  OnRowDeleting="GridView1_RowDeleting">
                                <Columns>
                                    <asp:CommandField ShowSelectButton="True" />
                                    <asp:BoundField DataField="id" HeaderText="id" />
                                    <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                    <asp:BoundField DataField="ap" HeaderText="Paterno" />
                                    <asp:BoundField DataField="am" HeaderText="Materno" />
                                    <asp:BoundField DataField="fnac" HeaderText="F. Nacimiento" />
                                    <asp:CommandField HeaderText="Eliminar" ShowDeleteButton="True" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <!-- Modal -->
    <div class="modal fade" id="MPregunta1" tabindex="-1" role="dialog" aria-labelledby="MPregunta1" aria-hidden="true">
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title" id="exampleModalLabel">Pregunta</h5>
            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
              <span aria-hidden="true">&times;</span>
            </button>
          </div>
          <div class="modal-body">
            ¿Esta seguro de eliminar el registro?
              
          </div>
            <label id="idr" runat="server"></label>
          <div class="modal-footer">
            <button type="button" class="btn btn-secondary" data-dismiss="modal">NO</button>
            <asp:Button ID="btnSI" runat="server" Text="SI" class="btn btn-primary" OnClick="btnSI_Click" />
              
          </div>
        </div>
      </div>
    </div>
</asp:Content>
