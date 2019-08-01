<%@ Page Title="" Language="C#" MasterPageFile="~/UnderWriter.Master" AutoEventWireup="true" CodeBehind="View_Assess_Application.aspx.cs" Inherits="team3.View_Assess_Application" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 217px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="body" runat="server">
    <form runat="server">
        <div class="container">

            <blockquote class="blockquote text-center">
                <p class="mb-0">Assess New Application</p>
            </blockquote>

            <div class="form-row">
                <table class="w-100">
                    <tr>
                        <td class="auto-style1">Application ID:</td>
                        <td>
                            <asp:Label ID="lbl_appID" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Date of Application:</td>
                        <td>
                            <asp:Label ID="lbl_filedDte" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Insurance Type:</td>
                        <td>
                            <asp:Label ID="lbl_insType" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1"></td>
                        <td></td>
                    </tr>
                </table>
            </div>
            
            <br />

            <div class="form-row">
                <div class="form-group col-12">
                    <label>Risk Assessment</label>
                    <asp:TextBox ID="tb_uwComments" runat="server" CssClass="form-control" Placeholder="Your Comments" TextMode="MultiLine" Rows="10"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter your assessment!" ControlToValidate="tb_uwComments" ForeColor="Red"></asp:RequiredFieldValidator>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group col-lg-3 col-xl-3 col-3">
                    <label>Estimated Annual Premium Rate</label>
                    <asp:TextBox ID="tb_pRate" runat="server" CssClass="form-control" placeholder="$"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please enter your estimated premium!" ControlToValidate="tb_pRate" ForeColor="Red"></asp:RequiredFieldValidator>
                    <asp:CustomValidator ID="CustomValidator1" runat="server" OnServerValidate="PRate_ServerValidation" ErrorMessage="Please enter a valid Rate" ValidateEmptyText="True" ControlToValidate="tb_pRate" EnableClientScript="False" ForeColor="Red"></asp:CustomValidator>
                </div>
            </div>

            <div class="form-row">
                <div class="form-group">
                    <asp:Button ID="btn_clear" runat="server" Text="Clear" CssClass="btn btn-outline-secondary" CausesValidation="False" OnClick="btn_clear_Click" />
                    <asp:Button ID="btn_confirm" runat="server" Text="Next" CssClass="btn btn-outline-success" OnClick="btn_confirm_Click"/>
                </div>
            </div>

        </div>
    </form>
</asp:Content>
