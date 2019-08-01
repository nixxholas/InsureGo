<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="Quote.aspx.cs" Inherits="team3.Quote" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 304px;
        }
        .auto-style3 {
            height: 26px;
            width: 304px;
        }
        .auto-style4 {
            width: 304px;
            height: 69px;
        }
        .auto-style5 {
            height: 69px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">

        <p style="font-size: x-large; font-weight: bold; font-style: normal">
        Quote
    </p>

    <table style="width: 100%;" class="table table-striped">
        <tr>
            <td class="auto-style2">Monthly Salary: $</td>
            <td>
                <asp:TextBox ID="TB_MthlySalary" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Term Period: </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DDL_TermPeriod" runat="server">
                    <asp:ListItem Value="0">--Please Select--</asp:ListItem>
                    <asp:ListItem Value="1">1 year</asp:ListItem>
                    <asp:ListItem Value="5">5 years</asp:ListItem>
                    <asp:ListItem Value="10">10 years</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Sum Insured:</td>
            <td>
                <asp:DropDownList ID="DDL_SumInsured" runat="server">
                    <asp:ListItem Value="0">--Please Select--</asp:ListItem>
                    <asp:ListItem Value="1">$10,000</asp:ListItem>
                    <asp:ListItem Value="2">$50,000</asp:ListItem>
                    <asp:ListItem Value="3">$90,000</asp:ListItem>
                    <asp:ListItem Value="4">$120,000</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Habit of Smoking: </td>
            <td class="auto-style1">
                <asp:RadioButtonList ID="RB_Smoke" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Do you have any serious medication:</td>
            <td class="auto-style5">
                <asp:RadioButtonList ID="RB_Medication" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Panel ID="Panel_Medication" runat="server">
                    Please State:</asp:Panel>
            </td>
            <td>
                <asp:Panel ID="Panel_Medication2" runat="server">
                    <asp:TextBox ID="TB_Medicaton" runat="server"></asp:TextBox>
                </asp:Panel>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td>
                <asp:Button ID="BTN_Clear" runat="server" Text="Clear" OnClick="BTN_Clear_Click" /> <br />
                <asp:Button ID="BTN_Submit2" runat="server" Text="Submit" />
            </td>
        </tr>
    </table>

    </form>
</asp:Content>
