<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="ProductDescription.aspx.cs" Inherits="team3.ProductDescription" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 551px;
        }
        .auto-style2 {
            width: 647px;
        }
        .auto-style3 {
            width: 809px;
        }
        .auto-style4 {
            width: 804px;
        }
        .auto-style5 {
            width: 713px;
        }
        .auto-style8 {
            height: 37px;
        }
        .auto-style9 {
            width: 647px;
            height: 37px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">
    <form runat="server">

        <asp:Label ID="Lbl_ProductName" runat="server"></asp:Label><br />
    <asp:Label ID="Lbl_ProductDescription" runat="server"></asp:Label><br />

    <asp:Button ID="Btn_Submit" runat="server" Text="Get Quote" OnClick="Btn_Submit_Click" />
    <asp:Panel ID="Panel_Medical" runat="server" Visible="False">
            <table style="width: 100%;" class="table table-striped">
        <tr>
            <td class="auto-style2">Monthly Salary:$<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_MthlySalary" ErrorMessage="State your monthly salary." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="TB_MthlySalary" CssClass="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Term Period: 
                <asp:RequiredFieldValidator ID="reqFieldCourse" runat="server" ControlToValidate="DDL_termPeriod" ErrorMessage="Select a term period." ForeColor="Red"  InitialValue="0" >*</asp:RequiredFieldValidator>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DDL_TermPeriod" CssClass="form-control"  runat="server">
                    <asp:ListItem Value="0">--Please Select--</asp:ListItem>
                    <asp:ListItem Value="1">1 year</asp:ListItem>
                    <asp:ListItem Value="5">5 years</asp:ListItem> 
                    <asp:ListItem Value="10">10 years</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">Sum Insured:<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="DDL_SumInsured" ErrorMessage="State the sum you want to be insured." ForeColor="Red" InitialValue="0">*</asp:RequiredFieldValidator>
            </td>
            <td class="auto-style8">
                <asp:DropDownList ID="DDL_SumInsured" CssClass="form-control" runat="server">
                    <asp:ListItem Value="0">--Please Select--</asp:ListItem>
                    <asp:ListItem Value="1">$10,000</asp:ListItem>
                    <asp:ListItem Value="2">$50,000</asp:ListItem>
                    <asp:ListItem Value="3">$90,000</asp:ListItem>
                    <asp:ListItem Value="4">$120,000</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Habit of Smoking: 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="RB_Smoke" ErrorMessage="Please state if your habit of smoking." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="auto-style1">
                <asp:RadioButtonList ID="RB_Smoke" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Do you have any serious medication:<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="RB_Medication" ErrorMessage="State if you have any serious medication." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td class="auto-style5">
                <asp:RadioButtonList ID="RB_Medication" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style9">
                    Please State:
            </td>
            <td class="auto-style8">
                    <asp:TextBox ID="TB_Medicaton" CssClass="form-control"  runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                &nbsp;</td>
            <td>
                <br />
                <asp:Button ID="BTN_Submit2" runat="server" Text="Submit"  />
                <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" HeaderText="Please resolve data entry error." ShowMessageBox="False" ShowSummary="True" />
            </td>
        </tr>

    </table>

    </asp:Panel>

    <asp:Panel ID="Panel_Endowment" runat="server" Visible="False">
        <table style="width: 100%;" class="table table-striped">
        <tr>
            <td class="auto-style2">Monthly Salary: $<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TB_mnthlySalary2" ErrorMessage="State monthly salary." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:TextBox ID="TB_mnthlySalary2" CssClass="form-control" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Term Period: 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="DDL_termPeriod2" ErrorMessage="Select a term period." ForeColor="Red" InitialValue="0">*</asp:RequiredFieldValidator>
            </td>
            <td class="auto-style1">
                <asp:DropDownList ID="DDL_termPeriod2" CssClass="form-control"  runat="server">
                    <asp:ListItem Value="0">--Please Select--</asp:ListItem>
                    <asp:ListItem Value="1">1 year</asp:ListItem>
                    <asp:ListItem Value="5">5 years</asp:ListItem>
                    <asp:ListItem Value="10">10 years</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Sum Insured:<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="DDL_sumInsured2" ErrorMessage="Select sum you want to be insured." ForeColor="Red" InitialValue="0">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:DropDownList ID="DDL_sumInsured2" CssClass="form-control" runat="server">
                    <asp:ListItem Value="0">--Please Select--</asp:ListItem>
                    <asp:ListItem Value="1">$10,000</asp:ListItem>
                    <asp:ListItem Value="2">$50,000</asp:ListItem>
                    <asp:ListItem Value="3">$90,000</asp:ListItem>
                    <asp:ListItem Value="4">$120,000</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Are you applying for another family member?<asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="RB_fam" ErrorMessage="State if you are applying for a family member." ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
            <td>
                <asp:RadioButtonList ID="RB_fam" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList></td>
        </tr>
            <tr>
            <td>If Yes, please enter family member's particulars:</td>
            <td>&nbsp</td>
        </tr>
            <tr>
            <td>Name:</td>
            <td>
                <asp:TextBox ID="TB_famname" CssClass="form-control"  runat="server"></asp:TextBox>
            </td>
        </tr>
            <tr>
            <td>Relationship: </td>
            <td>
                <asp:DropDownList ID="DDL_rs" CssClass="form-control"  runat="server">
                    <asp:ListItem Value="0">--Select--</asp:ListItem>
                    <asp:ListItem Value="1">Child(Son/Daughter)</asp:ListItem>
                    <asp:ListItem Value="2">Spouse</asp:ListItem>
                    <asp:ListItem Value="3">Parents(Mother/Father)</asp:ListItem>
                </asp:DropDownList>
                </td>
        </tr>
            <tr>
            <td>Occupation:</td>
            <td>
                <asp:TextBox ID="TB_occupation" runat="server" CssClass="form-control" ></asp:TextBox>
                </td>
        </tr>
            <tr>
            <td>&nbsp</td>
            <td>
                <asp:Button ID="BTN_Submit3" runat="server" Text="Submit" />
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText="Please resolve data entry error." ForeColor="Red" />
                </td>
        </tr>
            </table>
    </asp:Panel>

    </form>
</asp:Content>
