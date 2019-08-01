<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="Notifications.aspx.cs" Inherits="team3.Notifications" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="MsgDate" HeaderText="Date" />
            <asp:BoundField DataField="Notification" HeaderText="Message" />
        </Columns>
    </asp:GridView>
</asp:Content>
