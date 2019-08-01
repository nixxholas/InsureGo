<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="team3.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <form runat="server">
        <div class="jumbotron">
            <h1 class="display-4">Hello <asp:Label ID="lbl_name" runat="server"></asp:Label></h1>
            <p class="lead">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
            <hr class="my-4" />
            <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
        </div>
        
            <div class="jumbotron bg-transparent">
                <p style="font-size: x-large; font-weight: bold; font-style: normal">
                    Recomendation of Insurance Policy
                </p>

                    <table class="table table-striped col-12">
                    <tr>
                        <td class="auto-style2">I want to cover for </td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="DDL_ProductTypeReco" runat="server" >
                                <asp:ListItem Value="0">--Select--</asp:ListItem>
                                <asp:ListItem Value="1">medical needs</asp:ListItem>
                                <asp:ListItem Value="2">disability income</asp:ListItem>
                                <asp:ListItem Value="3">endowment</asp:ListItem>
                                <asp:ListItem Value="4">personal accident</asp:ListItem>
                                <asp:ListItem Value="5">life insurance</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style2">for premium amount ranging from $</td>
                        <td class="auto-style1">
                            <asp:DropDownList ID="DDL_ProductPremiumReco" runat="server" >
                                <asp:ListItem Value="0">--Select--</asp:ListItem>
                                <asp:ListItem Value="400">400-600</asp:ListItem>
                                <asp:ListItem Value="601">601-800</asp:ListItem>
                                <asp:ListItem Value="801">801-1000</asp:ListItem>
                                <asp:ListItem Value="1001">1001-1200</asp:ListItem>
                                <asp:ListItem Value="1201">1201-1400</asp:ListItem>
                                <asp:ListItem>1400 and above</asp:ListItem>
                            </asp:DropDownList>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style3">&nbsp;</td>
                        <td>
                            <asp:Button ID="BTN_Filter" runat="server" Text="Filter" OnClick="BTN_Filter_Click"  />
                        </td>
                    </tr>
                </table>
                <p>
                    <asp:GridView ID="GridView_Reccomendation" runat="server" CssClass="table table-striped" BorderStyle="None" AutoGenerateColumns="False" Visible="False" >
                        <Columns>
                            <asp:CommandField HeaderText="Select" ShowHeader="True" ShowSelectButton="True" />
                            <asp:BoundField DataField="productName" HeaderText="Insurance Product" />
                            <asp:BoundField DataField="productPremium" HeaderText="Premium Amount" />
                            <asp:BoundField DataField="productType" HeaderText="Product Type" />
                        </Columns>
                    </asp:GridView>
                </p>

                
            </div>
    </form>

    

</asp:Content>
