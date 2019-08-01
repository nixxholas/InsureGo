<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="View_Policies_Details.aspx.cs" Inherits="team3.View_Policies_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 217px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body_Content" runat="server">
    <form runat="server">

        <div class="container">

            <blockquote class="blockquote text-center">
                <p class="mb-0">View Policies Details</p>
            </blockquote>

            <div class="form-row">

                <table class="w-100">
                    <tr>
                        <td class="auto-style1">Policy Number:</td>
                        <td>
                            <asp:Label ID="lbl_PolicyNum" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Policy Type:</td>
                        <td>
                            <asp:Label ID="lbl_PolicyType" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Date of Commencement:</td>
                        <td>
                            <asp:Label ID="lbl_StartDate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Date of Maturity:</td>
                        <td>
                            <asp:Label ID="lbl_MaturedDate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Annual Premium Rate:</td>
                        <td>
                            <asp:Label ID="lbl_PRate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Customer NRIC:</td>
                        <td>
                            <asp:Label ID="lbl_NRIC" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Under Writer&#39;s Comments:</td>
                        <td>
                            <asp:Label ID="lbl_uwComments" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Admin Comments:</td>
                        <td>
                            <asp:Label ID="lbl_AdminComments" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>

            </div>
            <br />
            <div class="form-row">
                <div class="form-group col-lg-3 col-md-3 col-sm-6">
                    <asp:Panel ID="panel_renewal" runat="server" Visible="false">
                        <div class="dropdown">
                            <asp:DropDownList ID="ddl_renew_term" runat="server" CssClass="form-control">
                                <asp:ListItem Selected="True" Value="0">--Select Renewal Period--</asp:ListItem>
                                <asp:ListItem Value="1">1 Year</asp:ListItem>
                                <asp:ListItem Value="3">3 Years</asp:ListItem>
                                <asp:ListItem Value="5">5 Years</asp:ListItem>
                                <asp:ListItem Value="10">10 Years</asp:ListItem>
                                <asp:ListItem Value="15">15 Years</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </asp:Panel>
                </div>
            </div>    
            <div class="form-row">
                <div class="form-group">
                    <asp:Button ID="btn_back" runat="server" Text="Back" CssClass="btn btn-outline-primary" OnClick="btn_back_Click" />
                    <asp:Button ID="btn_renew" runat="server" Text="Renew Policy" CssClass="btn btn-outline-success" OnClick="btn_renew_Click"/>
                    <asp:Button ID="btn_confirm" runat="server" Text="Confirm" CssClass="btn btn-outline-secondary" Visible="false" OnClick="btn_confirm_Click" />
                </div>
            </div>
            <br />
        </div>
    </form>
</asp:Content>
