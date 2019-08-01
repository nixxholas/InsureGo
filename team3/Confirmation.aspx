<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="Confirmation.aspx.cs" Inherits="team3.Confirmation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
                
       
        td {
            text-align:left;
            
        }
        
        .auto-style2 {
            width: 563px;
        }
        
        .auto-style4 {
            width: 273px;
        }
        
        .auto-style5 {
            width: 273px;
            height: 39px;
        }
        .auto-style6 {
            width: 563px;
            height: 39px;
        }
        
        .auto-style7 {
            height: 40px;
        }
        
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <div class ="add">
    </div>
    <form runat="server" style="margin-left:30%; padding-top:10%">
                <asp:Panel ID="Panel1" runat="server">
                <div style="width:100%;height:100%;text-align:center;vertical-align:middle">
                <table class="table table-condensed">
                    <tr>
                        <td class="auto-style4">Full Name: </td>
                        <td class="auto-style2">
                            <asp:Label ID="Label_Name" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style5">NRIC:</td>
                        <td class="auto-style6">
                            <asp:Label ID="Label_NRIC" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">Date of incident:</td>
                        <td class="auto-style7">
                            <asp:Label ID="Label_Date1" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">Description on incident:</td>
                        <td class="auto-style2">
                            <asp:Label ID="Label_Description" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style4">
                            <asp:Button ID="backbutton1" runat="server" Text="Back" CssClass="btn btn-outline-secondary" Width="117px" OnClick="backbutton1_Click"/>
                        </td>
                        <td class="auto-style2">
                            <asp:Button ID="submitbutton1" runat="server" Text="Submit" CssClass="btn btn-outline-secondary" Width="117px" OnClick="submitbutton1_Click" />
                        </td>
                    </tr>
                    </table>
                    </div>
                    </asp:Panel>
                    <asp:Panel ID="Panel2" runat="server">
                    <div style="width:100%;height:100%;text-align:center;vertical-align:middle">
                    <table class="table table-condensed">
                        <tr>
                            <td class="auto-style4">Full Name:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_Name2" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">NRIC:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_NRIC2" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Location of incident:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_Location" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Description of incident:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_Description2" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Date of incident:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_Date" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:Button ID="backbutton2" runat="server" Text="Back" CssClass="btn btn-outline-secondary" Width="117px" OnClick="backbutton2_Click"/>
                            </td>
                            <td class="auto-style2">
                                <asp:Button ID="submitbutton2" runat="server" Text="Submit" CssClass="btn btn-outline-secondary" Width="117px" OnClick="submitbutton2_Click" />
                            </td>
                        </tr>
                    </table>
                    </asp:Panel>
                    <asp:Panel ID="Panel3" runat="server">
                    <div style="width:100%;height:100%;text-align:center;vertical-align:middle">
                    <table class="table table-condensed">
                        <tr>
                            <td class="auto-style4">Full Name:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_Name3" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">NRIC:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_NRIC3" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Type of disability:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_Disability" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Others:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_Others" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>Date of incident:</td>
                            <td>
                                <asp:Label ID="Label_Date3" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:Button ID="backbutton3" runat="server" Text="Back" CssClass="btn btn-outline-secondary" Width="117px" OnClick="backbutton3_Click"/>
                            </td>
                            <td class="auto-style2">
                                <asp:Button ID="submitbutton3" runat="server" Text="Submit" CssClass="btn btn-outline-secondary" Width="117px" OnClick="submitbutton3_Click"/>
                            </td>
                        </tr>
                    </table>
                    </div>
                    </asp:Panel>
                    <asp:Panel ID="Panel4" runat="server">
                    <div style="width:100%;height:100%;text-align:center;vertical-align:middle">
                    <table class="table table-condensed">
                        <tr>
                            <td class="auto-style4">Full name of deceased:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_DeceasedName" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">NRIC of deceased:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_DeceasedNRIC" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">Date of death:</td>
                            <td class="auto-style2">
                                <asp:Label ID="Label_DateOfDeath" runat="server"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style4">
                                <asp:Button ID="backbutton4" runat="server" Text="Back" CssClass="btn btn-outline-secondary" Width="117px" OnClick="backbutton4_Click"/>
                            </td>
                            <td class="auto-style2">
                                <asp:Button ID="submitbutton4" runat="server" Text="Submit" CssClass="btn btn-outline-secondary" Width="117px" OnClick="submitbutton4_Click"/>
                            </td>
                        </tr>
                    </table>
                    </asp:Panel>
        </form>

</asp:Content>
