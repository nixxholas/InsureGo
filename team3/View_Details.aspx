<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="View_Details.aspx.cs" Inherits="team3.View_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 217px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Body_Content" runat="server">
    <form id="form_details" runat="server" visible="True">

        <div class="container">
            <br />
            <div class="form-row">
                <asp:Button ID="btn_back" runat="server" Text="Back" CssClass="btn btn-outline-primary" CausesValidation="False" OnClick="btn_back_Click" />
            </div>
            <br />
            <div class="form-row">
                <table class="w-100">
                    <tr>
                        <td class="auto-style1">Application Number:</td>
                        <td>
                            <asp:Label ID="lbl_appID" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Date Applied:</td>
                        <td>
                            <asp:Label ID="lbl_filedDte" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Product Type:</td>
                        <td>
                            <asp:Label ID="lbl_type" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Status:</td>
                        <td>
                            <asp:Label ID="lbl_status" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Assessed By:</td>
                        <td>
                            <asp:Label ID="lbl_assStaff" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Annual Premium Rate:</td>
                        <td>
                            $<asp:Label ID="lbl_premium_rate" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <div class="form-row">
                <asp:Label ID="lbl_comments" runat="server"></asp:Label>
            </div>
            <div class="form-row">
                <asp:Label ID="lbl_uwcomments" runat="server" Enabled="false"></asp:Label>
            </div>
            <br />
            <div class="form-row">
                <asp:TextBox ID="tb_admin_comments" runat="server" CssClass="form-control" placeholder="Admin's Comments (if any)"></asp:TextBox>
            </div>
            <br />
            <div class="form-row">
                <div class="form-group">
                    <asp:Button ID="btn_reject" runat="server" Text="Reject" CssClass="btn btn-danger" OnClick="btn_reject_Click" />
                    <asp:Button ID="btn_approve" runat="server" Text="Approve" CssClass="btn btn-success" OnClick="btn_approve_Click" />
                </div>
            </div>
        </div>
    </form>
</asp:Content>
