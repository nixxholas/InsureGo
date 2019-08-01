<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="New_Application.aspx.cs" Inherits="team3.New_Application" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body_Content" runat="server">
    <form id="form1" runat="server">
        <blockquote class="blockquote text-center">
            <p class="mb-0">New Application</p>
        </blockquote>
        <div class="container">
            <label>Filters</label>
            <div class="form-row">
                <div class="form-group col-lg-3 col-md-3 col-sm-6">
                    <div class="dropdown">
                        <asp:DropDownList ID="ddl_Type" runat="server" CssClass="form-control" AutoPostBack="True" 
                            OnSelectedIndexChanged="ddl_Type_SelectedIndexChanged">
                            <asp:ListItem Value="0">--Select Type--</asp:ListItem>
                            <asp:ListItem Value="Life">Life Insurance</asp:ListItem>
                            <asp:ListItem Value="Medical">Medical Insurance</asp:ListItem>
                            <asp:ListItem>Endownment</asp:ListItem>
                            <asp:ListItem Value="Disability">Disability Income</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                
                <div class="form-group col-lg-3 col-md-3 col-sm-6">
                    <asp:DropDownList ID="StatusDdl" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="StatusDdl_SelectedIndexChanged">
                        <asp:ListItem Selected="True" Value="0">--Select Status--</asp:ListItem>
                        <asp:ListItem Value="Pending Assesment">Pending Assesment</asp:ListItem>
                        <asp:ListItem Value="Pending Approval">Pending Approval</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="form-group col-lg-2 col-md-2">
                    <asp:TextBox ID="Search" runat="server" CssClass="form-control" placeholder="Application No"></asp:TextBox>
                </div>

                <div class="form-group col-lg-2 col-md-2">
                    <asp:Button ID="FilterBtn" runat="server" Text="Filter" CssClass="btn btn-outline-secondary" OnClick="FilterBtn_Click"/>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-lg-2 col-md-2">
                    <label for="SortingDdl">Sort By</label>
                    <asp:DropDownList ID="SortingDdl" runat="server" CssClass="form-control dropdown" OnSelectedIndexChanged="SortingDdl_SelectedIndexChanged" AutoPostBack="True">
                        <asp:ListItem>Latest</asp:ListItem>
                        <asp:ListItem>Oldest</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-lg-12 col-xl-12 col-md-12">
                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-borderless table-hover table-striped" BorderStyle="None" AutoGenerateColumns="False" DataKeyNames="appID" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="appID" HeaderText="Application No" />
                            <asp:BoundField DataField="type" HeaderText="Type" />
                            <asp:BoundField DataField="filedDte" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date of Filing" />
                            <asp:BoundField DataField="Status" HeaderText="Status" />
                            <asp:CommandField CausesValidation="False" SelectText="icon" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>    
                </div>
            </div>
             
                     
        </div>
        
        
        
    </form>
</asp:Content>

