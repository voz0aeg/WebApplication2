<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Ej2.aspx.cs" Inherits="WebApplication2.Ej2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="row">
        <div class="col-md-6 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">
                    <h4 class="card-title">Número mayor</h4>
                    <div class="form-group row">
                        <label class="col-sm-3 col-form-label">Entero:</label>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtEntero1" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label class="col-sm-3 col-form-label">Entero:</label>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtEntero2" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label class="col-sm-3 col-form-label">Entero:</label>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtEntero3" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
                        </div>
                    </div>
                    <asp:Button ID="btnEjecutar" runat="server" Text="Ejecutar" class="btn btn-primary mr-2" OnClick="btnEjecutar_Click" />
                    <div class="form-group row">
                        <label class="col-sm-3 col-form-label">El Mayor es:</label>
                        <div class="col-sm-9">
                            <asp:TextBox ID="txtResultado" runat="server" class="form-control" TextMode="Number" ReadOnly="true"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
