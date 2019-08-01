<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="Submission.aspx.cs" Inherits="team3.Submission" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style17 {
            width: 340px;
            height: 70px;
        }
        </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <form runat="server">
        <br/>
        <br/>
       <h2 align="center"><asp:Label ID="thankyou" runat="server" Text="Thank you for filing your claim with InsureGo, our company will process your claim within the next 3 working days."></asp:Label></h2>
        <div class="container" style="margin-left:45%; height: 46px;">
            <div class="form-row text-center">
                <asp:Button ID="proceeed" runat="server" Text="Home" CssClass="btn btn-outline-secondary" Width="117px" OnClick="proceeed_Click"/>

            </div>
        </div>
        
    </form>

</asp:Content>
