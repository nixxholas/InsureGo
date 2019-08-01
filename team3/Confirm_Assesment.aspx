<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Confirm_Assesment.aspx.cs" Inherits="team3.Confirm_Assesment" %>
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

            <h1 class="display-3 text-center">Confirmation</h1>

            
            <div class="form-row">
                <table class="w-100">
                    <tr>
                        <td class="auto-style1">Application Number:</td>
                        <td>
                            <asp:Label ID="lbl_appID" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">UnderWriter&#39;s Comment:</td>
                        <td>
                            <asp:Label ID="lbl_uwComment" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            Annual Premium Rate:
                        </td>
                        <td>
                            $<asp:Label ID="lbl_Premium" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <br />

            <div class="form-row">
                <div class="form-group">
                    <asp:Button ID="btn_cancel" runat="server" Text="Cancel" CssClass="btn btn-outline-info" OnClick="btn_cancel_Click" />
                    <asp:Button ID="btn_confirm" runat="server" Text="Confirm" CssClass="btn btn-outline-success" OnClick="btn_confirm_Click" />
                </div>
            </div>

        </div>
    </form>

</asp:Content>
