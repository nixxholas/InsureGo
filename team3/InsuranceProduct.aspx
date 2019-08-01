<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="InsuranceProduct.aspx.cs" Inherits="team3.InsuranceProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">

        <h3>Products:</h3>

    <asp:DropDownList ID="DDL_FilterProduct" runat="server">
        <asp:ListItem Value="0">--Select--</asp:ListItem>
        <asp:ListItem Value="Medical">Medical</asp:ListItem>
        <asp:ListItem Value="Endowment">Endowment</asp:ListItem>
        <asp:ListItem Value="Disability Income">Disability Income</asp:ListItem>
        <asp:ListItem Value="Personal Accident">Personal Accident</asp:ListItem>
        <asp:ListItem Value="Life Insurance">Life Insurance</asp:ListItem>
        <asp:ListItem Value="Travel">Travel</asp:ListItem>
    </asp:DropDownList>
    
    <br />
    
    <asp:Button ID="BTN_Search" runat="server" Text="Search" OnClick="BTN_Search_Click" />

    <br />
    <br />
    <asp:GridView ID="GridView_Product" runat="server" AutoGenerateColumns="False"
             CssClass="table table-striped" OnSelectedIndexChanged="GridView_Product_SelectedIndexChanged" >

             <Columns>
                 <asp:CommandField HeaderText="Select" ShowHeader="True" ShowSelectButton="True" ItemStyle-CssClass="hidden-sm hidden-xs" HeaderStyle-CssClass="hidden-sm hidden-xs" />
                 <asp:BoundField DataField="productName" HeaderText="Insurance Product"  />
                 <asp:BoundField DataField="productDescription" HeaderText="Description" />
                 <asp:BoundField DataField="productPremium" HeaderText="Premium"/>
                 <asp:BoundField DataField="productPeriod" HeaderText="Term Period" />
                 <asp:BoundField DataField="productType" HeaderText="Product Type"> 
                 </asp:BoundField>


             </Columns>
         </asp:GridView>

    </form>
</asp:Content>
