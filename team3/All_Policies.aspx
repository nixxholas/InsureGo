<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="All_Policies.aspx.cs" Inherits="team3.All_Policies" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body_Content" runat="server">
    <form runat="server">

        <blockquote class="blockquote text-center">
            <p class="mb-0">All Policies</p>
        </blockquote>

        <div class="container">
            <label>Filters</label>
            <div class="form-row">

                <div class="form-group col-lg-3 col-md-3 col-sm-6">
                    <div class="dropdown">
                        <asp:DropDownList ID="ddl_Status" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="ddl_Status_SelectedIndexChanged">
                            <asp:ListItem Selected="True" Value="0">--Status--</asp:ListItem>
                            <asp:ListItem Value="1">Active</asp:ListItem>
                            <asp:ListItem Value="2">Expired</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>

                <div class="form-group col-lg-2 col-md-2">
                    <asp:TextBox ID="tb_Search" runat="server" CssClass="form-control" placeholder="Policy No"></asp:TextBox>
                </div>

                <div class="form-group col-lg-2 col-md-2">
                    <asp:TextBox ID="tb_cust" runat="server" CssClass="form-control" placeholder="Customer NRIC"></asp:TextBox>
                </div>

                <div class="form-group col-lg-2 col-md-2">
                    <asp:Button ID="btn_Filter" runat="server" Text="Filter" CssClass="btn btn-outline-secondary" OnClick="btn_Filter_Click" />
                </div>

            </div>

            <div class="form-row">
                <div class="form-group col-lg-2 col-md-2">
                    <label for="ddl_sorting">Sort By</label>
                    <asp:DropDownList ID="ddl_sorting" runat="server" CssClass="form-control dropdown" AutoPostBack="True" OnSelectedIndexChanged="ddl_sorting_SelectedIndexChanged">
                        <asp:ListItem Value="0">Oldest</asp:ListItem>
                        <asp:ListItem Selected="True" Value="1">Latest</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-lg-12 col-xl-12 col-md-12">
                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-borderless table-hover table-striped" BorderStyle="None" AutoGenerateColumns="False" DataKeyNames="PolicyNum" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                        <Columns>
                            <asp:BoundField DataField="PolicyNum" HeaderText="Policy Number" />
                            <asp:BoundField DataField="CustomerNRIC" HeaderText="Customer" />
                            <asp:BoundField DataField="PolicyType" HeaderText="Type" />
                            <asp:BoundField DataField="StartDate" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Start Date" />
                            <asp:BoundField DataField="MaturedDate" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Date of Maturity" />
                            <asp:CommandField SelectText="Details" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
            
        </div>
    </form>
</asp:Content>
