<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="Claims.aspx.cs" Inherits="team3.Claims" %>
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
       <h1 align="center"><asp:Label ID="Label1" runat="server" Text="What type of claim is it?"></asp:Label></h1>
            <div align="center" class="container">
                <div class="col-lg-4">
                    <div class="form-group">
                        <asp:DropDownList ID="DropDownList4" runat="server" DataSourceID="SqlDataSource1" CssClass="form-control" DataTextField="PolicyType" DataValueField="PolicyType" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList>
                        <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectDB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT DISTINCT [PolicyType] FROM [Policy] WHERE ([Customer_NRIC_FK] = @Customer_NRIC_FK)">
                            <SelectParameters>
                                <asp:SessionParameter SessionField="NRIC" Name="Customer_NRIC_FK" Type="String"></asp:SessionParameter>
                            </SelectParameters>
                        </asp:SqlDataSource>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="Okaybutton" runat="server" Text="Okay" CssClass="btn btn-outline-secondary" OnClick="Okaybutton_Click" CausesValidation="False"/>
                    </div>
                
                </div>
        
                <asp:Panel ID="Medbenefits" runat="server" Visible="false" Height="491px">
                        
                        <table >
                            <tr>
                               <td colspan="2" align="left" class="auto-style17">Dear Claimant,<br />We are sorry to learn of your accident/illness<br />In order for us to process your claim, we require the following: 
                                   <br />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17">Full Name: 
                                    </td>
                                <td align="left" class="auto-style17"><asp:TextBox ID="Nametext1" runat="server" CssClass="form-control" ></asp:TextBox></td>
                            </tr>
                            <tr>
                                <td class="auto-style17">NRIC:</td>
                                <td align="left" class="auto-style17"><asp:TextBox ID="NRICtext1" runat="server" CssClass="form-control" Width="208px"></asp:TextBox></td>
                            </tr>
                            <tr>
                               <td class="auto-style17">Policy Number:</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList5" runat="server" CssClass="form-control" DataSourceID="SqlDataSource2" DataTextField="PolicyNum" DataValueField="PolicyNum"></asp:DropDownList><asp:SqlDataSource runat="server" ID="SqlDataSource2" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectDB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [PolicyNum] FROM [Policy] WHERE (([Customer_NRIC_FK] = @Customer_NRIC_FK) AND ([PolicyType] = @PolicyType))">
                                        <SelectParameters>
                                            <asp:SessionParameter SessionField="NRIC" Name="Customer_NRIC_FK" Type="String"></asp:SessionParameter>
                                            <asp:Parameter DefaultValue="Medical" Name="PolicyType" Type="String"></asp:Parameter>
                                        </SelectParameters>
                                    </asp:SqlDataSource>
                                </td>
                            </tr>
                            <tr>
                                <td>Date of incident:</td>
                                <td><asp:Calendar ID="Calendar3" runat="server"></asp:Calendar></td>
                            </tr>
                            <tr>
                                <td class="auto-style17">Brief description on incident: 
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="incidenttext" ErrorMessage="Description is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </td>
                                <td align="left" class="auto-style17">
                                    <asp:TextBox ID="incidenttext" runat="server" CssClass="form-control" Columns="3" Height="100px"  Rows="3" TextMode="MultiLine" Width="220px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17">Attachment of medical receipt:</td>
                                <td align="center" class="auto-style17">
                                    <asp:Button ID="Attachmentreceipt2" runat="server" CssClass="btn btn-outline-secondary" Text="Upload" Width="151px" />
                                </td>
                            </tr>
                            <tr>
                                <td align="center" class="auto-style17" colspan="2">
                                    <asp:Button ID="comfirmation1" runat="server" CssClass="btn btn-outline-secondary" Text="Confirm" OnClick="comfirmation1_Click" />
                                    
                                </td>
                            </tr>
                        </table>
                        </asp:Panel>
                
                        <asp:Panel ID="travelruption" runat="server" Visible="False">
                        <table>
                    <tr>
                        <td colspan="2">Dear Claimant,
                            <br />
                            We are sorry to know about the unforeseen circumstances<br /> that you have encountered during your travel
                            <br />
                            However, you are required to provide us with these information below
                            <br />
                            for us to help you with your claim </td>
                    </tr>
                    <tr>
                    
                            <td class="auto-style17">Full Name: </td>
                            <td align="left" class="auto-style17">
                            <asp:TextBox ID="Nametext2" runat="server" CssClass="form-control"></asp:TextBox>
                            </td>
                    </tr>
                        
                        <tr>
                            <td class="auto-style17">NRIC: </td>
                            <td align="left" class="auto-style17">
                                <asp:TextBox ID="NRIC2" runat="server" CssClass="form-control"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style17">Policy Number:</td>
                            <td>
                                <asp:DropDownList ID="DropDownList6" CssClass="form-control" runat="server" DataSourceID="SqlDataSource4" DataTextField="PolicyNum" DataValueField="PolicyNum"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource4" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectDB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [PolicyNum] FROM [Policy] WHERE (([PolicyType] = @PolicyType) AND ([Customer_NRIC_FK] = @Customer_NRIC_FK))">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="Travel" Name="PolicyType" Type="String"></asp:Parameter>
                                        <asp:SessionParameter SessionField="NRIC" Name="Customer_NRIC_FK" Type="String"></asp:SessionParameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                        </tr>
                     
                            <tr>
                                <td class="auto-style17">Location of the incident:<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="DropDownList2" ErrorMessage="Location is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                                </td>
                                <td align="left" class="auto-style17">
                                    <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" CssClass="form-control">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>Date of incident:</td>
                                <td><asp:Calendar ID="Calendar2" runat="server"></asp:Calendar></td>
                            </tr>
                                
                                <tr>
                                    <td class="auto-style17">Description of the incident:<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox1" ErrorMessage="Description is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                                    </td>
                                    <td align="left" class="auto-style17">
                                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" Rows="3" TextMode="MultiLine" Width="220px"></asp:TextBox>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" class="auto-style17" colspan="2">
                                        <asp:Button ID="confirmation2" runat="server" CssClass="btn btn-outline-secondary" Height="44px" OnClick="confirmation2_Click" Text="Confirm" />
                                    </td>
                                </tr>
                        </table>
                        </asp:Panel>
                
                <asp:Panel ID="Disabilities" runat="server" Visible="false">
                        <table>
                        <tr>
                        <td colspan="2">Dear Claimant,
                        <br />
                        Received your request on filing a claim due to disability
                        <br />
                        To process your claim, we require the following details:
                        </td>
                        
                        </tr>
                        <tr>
                        <td class="auto-style17">Full Name:</td>
                        <td class="auto-style17"><asp:TextBox ID="Nametext3" runat="server" CssClass="form-control"></asp:TextBox></td>
                        
                        </tr>
                    
                    <tr>
                        <td class="auto-style17">NRIC:</td>
                        <td align="left" class="auto-style17">
                            <asp:TextBox ID="NRIC3" runat="server" CssClass="form-control"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style17">Policy Number:</td>
                        <td>
                            <asp:DropDownList ID="DropDownList7" CssClass="form-control" runat="server" DataSourceID="SqlDataSource3" DataTextField="PolicyNum" DataValueField="PolicyNum"></asp:DropDownList>
                            <asp:SqlDataSource runat="server" ID="SqlDataSource3" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectDB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [PolicyNum] FROM [Policy] WHERE (([PolicyType] = @PolicyType) AND ([Customer_NRIC_FK] = @Customer_NRIC_FK))">
                                <SelectParameters>
                                    <asp:Parameter DefaultValue="Disability" Name="PolicyType" Type="String"></asp:Parameter>
                                    <asp:SessionParameter SessionField="NRIC" Name="Customer_NRIC_FK" Type="String"></asp:SessionParameter>
                                </SelectParameters>
                            </asp:SqlDataSource>
                        </td>
                    </tr>
                        
                        <tr>
                            <td class="auto-style17">Type of disability:<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList3" ErrorMessage="Please select disability type" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                            <td align="left" class="auto-style17">
                                <asp:DropDownList ID="DropDownList3" runat="server" CssClass="form-control">
                                    <asp:ListItem>Please select</asp:ListItem>
                                    <asp:ListItem>Mobility and physical impairment</asp:ListItem>
                                    <asp:ListItem>Spinal Cord disability</asp:ListItem>
                                    <asp:ListItem>Brain disability</asp:ListItem>
                                    <asp:ListItem>Vision disability</asp:ListItem>
                                    <asp:ListItem>Hearing disability</asp:ListItem>
                                    <asp:ListItem>Cognitive or learning disabilities</asp:ListItem>
                                    <asp:ListItem>Psychological disorders</asp:ListItem>
                                    <asp:ListItem>Others</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                            
                            <tr>
                                <td class="auto-style17">If others, please specify:</td>
                                <td align="left" class="auto-style17">
                                    <asp:TextBox ID="specify1" runat="server" CssClass="form-control"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>Date of incident:</td>
                                <td><asp:Calendar ID="Calendar5" runat="server"></asp:Calendar></td>
                            </tr>
                                
                                <tr>
                                    <td class="auto-style17">Attachment of medical report:</td>
                                    <td align="center" class="auto-style17">
                                        <asp:Button ID="report2" runat="server" CssClass="btn btn-outline-secondary" Text="Upload" Width="151px" />
                                    </td>
                                </tr>
                                
                                <tr>
                                    <td align="center" class="auto-style17" colspan="2">
                                        <asp:Button ID="Confirmation3" runat="server" CssClass="btn btn-outline-secondary" Text="Confirm" OnClick="Confirmation3_Click" />
                                        </td>
                                </tr>
                    </table>
                </asp:Panel>
                <asp:Panel ID="Deathsurance" runat="server" Visible="False" >
                    <table>
                        <tr>
                        <td colspan="2">Dear Claimant,
                        <br />
                        Sorry to hear about the death of your kin,
                        <br />
                        Please provide us will the following details for us to process the death claim.
                        </td>
                        </tr>
                        <tr>
                        <td class="auto-style17">Full name of deceased:<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="Nametext4" ErrorMessage="Deceased namme is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td>
                        <td class="auto-style17"><asp:TextBox ID="Nametext4" runat="server" CssClass="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                        <td class="auto-style17">NRIC of deceased:<asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="NRIC4" ErrorMessage="Deceased NRIC is required" ForeColor="Red">*</asp:RequiredFieldValidator>
                            </td> 
                        <td class="auto-style17"><asp:TextBox ID="NRIC4" runat="server" CssClass="form-control"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td class="auto-style17">Policy Number:</td>
                            <td>
                                <asp:DropDownList ID="DropDownList8" CssClass="form-control" runat="server" DataSourceID="SqlDataSource6" DataTextField="PolicyNum" DataValueField="PolicyNum"></asp:DropDownList>
                                <asp:SqlDataSource runat="server" ID="SqlDataSource6" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\projectDB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [PolicyNum] FROM [Policy] WHERE (([PolicyType] = @PolicyType) AND ([Customer_NRIC_FK] = @Customer_NRIC_FK))">
                                    <SelectParameters>
                                        <asp:Parameter DefaultValue="Life" Name="PolicyType" Type="String"></asp:Parameter>
                                        <asp:SessionParameter SessionField="NRIC" Name="Customer_NRIC_FK" Type="String"></asp:SessionParameter>
                                    </SelectParameters>
                                </asp:SqlDataSource>
                            </td>
                        </tr>
                        <tr>
                        <td class="auto-style17">Date of death:</td>
                        <td class="auto-style17"><asp:Calendar ID="Calendar4" runat="server"></asp:Calendar></td>
                        </tr>
                        <tr>
                        <td class="auto-style17">Attachment of death certificate:</td>
                        <td align="center" class="auto-style17">
                        <asp:Button ID="Deathcert2" runat="server" Text="Upload" CssClass="btn btn-outline-secondary" Width="151px" />
                        </td>
                        
                        </tr>
                        <tr>
                        <td align="center" class="auto-style17" colspan="2">
                            <asp:Button ID="Confirmation4" runat="server" Text="Confirm" CssClass="btn btn-outline-secondary" OnClick="Confirmation4_Click"/>
                        </td>
                        </tr>
                      </table>
                </asp:Panel>
            </div>
    </form>

</asp:Content>
