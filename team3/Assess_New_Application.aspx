<%@ Page Title="" Language="C#" MasterPageFile="~/UnderWriter.Master" AutoEventWireup="true" CodeBehind="Assess_New_Application.aspx.cs" Inherits="team3.Assess_New_Application" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <form runat="server">
        <blockquote class="blockquote text-center">
            <p class="mb-0">New Application</p>
        </blockquote>

        <div class="container">
            <label>Sort By</label>
            <div class="form-row">
                <div class="form-group">
                    <asp:DropDownList ID="ddl_sort" CssClass="form-control dropdown" AutoPostBack="true" runat="server" OnSelectedIndexChanged="ddl_sort_SelectedIndexChanged">
                        <asp:ListItem Selected="True" Value="0">--Order By--</asp:ListItem>
                        <asp:ListItem Value="1">Latest</asp:ListItem>
                        <asp:ListItem Value="2">Oldest</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-lg-12 col-xl-12 col-md-12">
                    <asp:GridView ID="GridView1" runat="server" CssClass="table table-borderless table-hover table-striped" BorderStyle="None" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="appID">
                        <Columns>
                            <asp:BoundField DataField="appID" HeaderText="New Application ID" />
                            <asp:BoundField DataField="filedDte" HeaderText="Date of Application" DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField DataField="type" HeaderText="Type" />
                            <asp:CommandField SelectText="Details" ShowSelectButton="True" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
