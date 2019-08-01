<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="View_Claim_Application.aspx.cs" Inherits="team3.View_Claim_Application" %>
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

            <br />
            <div class="form-row">
                <asp:Button ID="btn_back" runat="server" Text="Back" CssClass="btn btn-outline-primary" CausesValidation="False" OnClick="btn_back_Click" />
            </div>
            <br />
            <div class="form-row">

                <table class="w-100">
                    <tr>
                        <td class="auto-style1">Claim Application Number:</td>
                        <td>
                            <asp:Label ID="lbl_ClaimID" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Claim Status:</td>
                        <td>
                            <asp:Label ID="lbl_Status" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Incident Date:</td>
                        <td>
                            <asp:Label ID="lbl_IncidentDate" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Location:</td>
                        <td>
                            <asp:Label ID="lbl_Location" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Policy Type:</td>
                        <td>
                            <asp:Label ID="lbl_PolicyType" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Filed Date:</td>
                        <td>
                            <asp:Label ID="lbl_FiledDte" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">Claim Amount:</td>
                        <td>$<asp:Label ID="lbl_ClaimAmount" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
                <asp:Panel ID="panel_Disability" runat="server" Visible="false">
                    <table class="w-100">
                        <tr>
                            <td class="auto-style1">Disability Type:</td>
                            <td>
                                <asp:Label ID="lbl_DisabilityType" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
                <asp:Panel ID="panel_Life" runat="server" Visible="false">
                    <table class="w-100">
                        <tr>
                            <td class="auto-style1">Deceased Name:</td>
                            <td>
                                <asp:Label ID="lbl_DeceasedName" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style1">
                                Deceased NRIC:
                            </td>
                            <td>
                                <asp:Label ID="lbl_DeceasedNRIC" runat="server"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </div>
            <br />
            <div class="form-row">
                Under Writer's Comment:
            </div>
            <div class="form-row">
                <asp:Label ID="lbl_uwComment" runat="server"></asp:Label>
            </div>
            <br />
            <div class="form-row">
                <asp:TextBox ID="tb_adminComment" runat="server" CssClass="form-control" TextMode="MultiLine" placeholder="Admin's Comment (if any)" Rows="10"></asp:TextBox>
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
