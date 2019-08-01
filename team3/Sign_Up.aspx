<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="Sign_Up.aspx.cs" Inherits="team3.Sign_Up" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
       :root {
  --input-padding-x: 1.5rem;
  --input-padding-y: .75rem;
}

body {
  
}

.card-signin {
  border: 0;
  border-radius: 1rem;
  box-shadow: 0 0.5rem 1rem 0 rgba(0, 0, 0, 0.1);
  overflow: hidden;
}

.card-signin .card-title {
  margin-bottom: 2rem;
  font-weight: 300;
  font-size: 1.5rem;
}

.card-signin .card-img-left {
  width: 45%;
  /* Link to your background image using in the property below! */
  background: scroll center url('https://source.unsplash.com/WEQbe2jBg40/414x512');
  background-size: cover;
}

.card-signin .card-body {
  padding: 2rem;
}

.form-signin {
  width: 100%;
}

.form-signin .btn {
  font-size: 80%;
  border-radius: 5rem;
  letter-spacing: .1rem;
  font-weight: bold;
  padding: 1rem;
  transition: all 0.2s;
}

.form-label-group {
  position: relative;
  margin-bottom: 1rem;
}

.form-label-group input {
  height: auto;
  border-radius: 2rem;
}

.form-label-group>input,
.form-label-group>label {
  padding: var(--input-padding-y) var(--input-padding-x);
}

.form-label-group>label {
  position: absolute;
  top: 0;
  left: 0;
  display: block;
  width: 100%;
  margin-bottom: 0;
  /* Override default `<label>` margin */
  line-height: 1.5;
  color: #495057;
  border: 1px solid transparent;
  border-radius: .25rem;
  transition: all .1s ease-in-out;
}

.form-label-group input::-webkit-input-placeholder {
  color: transparent;
}

.form-label-group input:-ms-input-placeholder {
  color: transparent;
}

.form-label-group input::-ms-input-placeholder {
  color: transparent;
}

.form-label-group input::-moz-placeholder {
  color: transparent;
}

.form-label-group input::placeholder {
  color: transparent;
}

.form-label-group input:not(:placeholder-shown) {
  padding-top: calc(var(--input-padding-y) + var(--input-padding-y) * (2 / 3));
  padding-bottom: calc(var(--input-padding-y) / 3);
}

.form-label-group input:not(:placeholder-shown)~label {
  padding-top: calc(var(--input-padding-y) / 3);
  padding-bottom: calc(var(--input-padding-y) / 3);
  font-size: 12px;
  color: #777;
}

.btn-google {
  color: white;
  background-color: #ea4335;
}

.btn-facebook {
  color: white;
  background-color: #3b5998;
}
       .auto-style2 {
           position: relative;
           margin-bottom: 1rem;
           left: -5px;
           top: -5px;
           width: 420px;
           height: 37px;
       }
       .auto-style4 {
           position: relative;
           margin-bottom: 1rem;
           left: -3px;
           top: 109px;
           width: 887px;
       }
       .auto-style5 {
        display: block;
        font-size: 1rem;
        font-weight: 400;
        line-height: 1.5;
        color: #495057;
        background-clip: padding-box;
        border-radius: .25rem;
        transition: none;
        border: 1px solid #ced4da;
        background-color: #fff;
    }
       </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <form class="form-signin" runat="server"> 
  <div class="container">
    <div class="row">
      <div class="col-lg-10 col-xl-9 mx-auto">
          <div class="card-body">
            <h5 class="card-title text-center">Register</h5>
            
              <asp:Label ID="PParticulars" runat="server" Text="Personal Particulars"></asp:Label>
              <hr />     
                <div class="auto-style2">
                    <asp:TextBox ID="tbNRIC" CssClass ="form-control " runat="server" Width="414px" placeholder="NRIC" style="margin-top: 0"  ></asp:TextBox>
                   <br />
                     <asp:Label ID="Label1" runat="server" Text="Gender"></asp:Label>
                    <asp:RadioButtonList ID="rdblGender" runat="server" RepeatDirection="Horizontal" placeholder="Gender:"> 
                         <asp:ListItem Value="F">Female</asp:ListItem>
                         <asp:ListItem Value="M">Male</asp:ListItem>
                    </asp:RadioButtonList>
                     <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="^Please select a gender!^" ForeColor="Red" ValidateEmptyText="True" ControlToValidate="rdblGender"></asp:CustomValidator>
                  
                </div>
                <div class="auto-style4">
                    <asp:TextBox ID="tbFname" CssClass ="form-control " runat="server" placeholder="Full name as in NRIC" Width="401px" CausesValidation="True" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="^Please enter your full name as per NRIC!^" ForeColor="Red" ControlToValidate="tbFname"></asp:RequiredFieldValidator>
                    <br />
                    <asp:TextBox ID="tbDate" runat="server" TextMode="Date" Width="185px" CssClass ="auto-style5" placeholder="Date of Birth" CausesValidation="True"></asp:TextBox>
                    
                    <br />
                    <asp:TextBox ID="tbEmailAddress" CssClass ="form-control " runat="server" placeholder="Email Address" Width="406px" ></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="^Please enter a valid email address^" ControlToValidate="tbEmailAddress" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    <br />
                    <asp:TextBox ID="tbPassword" TextMode="Password" CssClass ="form-control " runat="server" placeholder="Password" style="margin-bottom: 0" Width="302px" ></asp:TextBox>
                    <br />
                    <asp:TextBox ID="tbCPassword" TextMode="Password" CssClass ="form-control " runat="server" placeholder="Confirm Password" Width="308px" ></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="^The password does not match! please type again!" ControlToCompare="tbPassword" ControlToValidate="tbCPassword" ForeColor="Red"></asp:CompareValidator>
                    <br />
                    <br />
                    <asp:Label ID="RAddress" runat="server" Text="Residential Address"></asp:Label>
                    <hr />
                    <asp:TextBox ID="tbRAddress" CssClass ="form-control " runat="server" placeholder="Residential Address"  Width="488px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="^Please enter your residential address!" ControlToValidate="tbRAddress" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />

                    <asp:TextBox ID="tbRPostalCode" CssClass ="form-control " runat="server" placeholder="Postal Code"  Width="122px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ErrorMessage="^Please enter a valid Postal Code!" ControlToValidate="tbRPostalCode" ForeColor="Red" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                    <br />
                    <asp:TextBox ID="tbNo" CssClass ="form-control " runat="server" placeholder="Phone Number" Width="267px"  />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ErrorMessage="^Please enter a valid phone no!" ControlToValidate="tbNo" ForeColor="Red" ValidationExpression="^[89]\d{7}$"></asp:RegularExpressionValidator>
                    <br />
                    <asp:TextBox ID="tbHNo" CssClass ="form-control " runat="server" placeholder="Home Number"  Width="264px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ErrorMessage="Please enter a valid Home number" ForeColor="Red" ValidationExpression="^[6]\d{7}$" ControlToValidate="tbHNo"></asp:RegularExpressionValidator>
                    <br />
                    <br />

                     <asp:Label ID="OfficeAddress" runat="server" Text="Office Address"></asp:Label>
                    <hr />
                    <asp:TextBox ID="tbOAddress" CssClass ="form-control " runat="server" placeholder="Office Address" Width="484px"></asp:TextBox>
                    <br />
                    <asp:TextBox ID="tbOPostalCode" CssClass ="form-control " runat="server" placeholder="Postal Code" Width="123px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server" ErrorMessage="^Please enter a valid Postal Code!" ControlToValidate="tbOPostalCode" ForeColor="Red" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                    <br />
                    <asp:TextBox ID="tbONo" CssClass ="form-control " runat="server" placeholder="Office Number" Width="258px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server" ErrorMessage="^Please enter a valid Office number" ForeColor="Red" ValidationExpression="^[6]\d{7}$" ControlToValidate="tbONo"></asp:RegularExpressionValidator>
                    <br />
                    <br />

                     <asp:Label ID="BankDetails" runat="server" Text="Bank Details"></asp:Label>
                    <hr />
                    <asp:Label ID="BankName" runat="server" Text="Bank Name"></asp:Label>
                    <asp:DropDownList ID="ddlBankName" runat="server" >
                        <asp:ListItem Selected="True">--Please Select--</asp:ListItem>
                        <asp:ListItem>OCBC</asp:ListItem>
                        <asp:ListItem>UOB</asp:ListItem>
                        <asp:ListItem Value="POSB">POSB</asp:ListItem>
                        <asp:ListItem>DBS</asp:ListItem>
                    </asp:DropDownList>
                    
                    <br/>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlBankName" ErrorMessage="^Please select a participating Bank" ForeColor="Red" InitialValue="-1"></asp:RequiredFieldValidator>
                    <asp:TextBox ID="tbAccountNo" CssClass ="form-control " runat="server" placeholder="Bank Account Number" Width="232px"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server" ErrorMessage="^Please enter a valid bank account number!" ControlToValidate="tbAccountNo" ForeColor="Red" ValidationExpression="\d{9}"></asp:RegularExpressionValidator>
                    <br/>
                     
                    <br/>
                    </div>

                <br/>
                <br/>
                <br/>
                <asp:Label ID="LblMsg" runat="server" ForeColor="Green"></asp:Label>
              <asp:Label ID="LblErr" runat="server" ForeColor="Red"></asp:Label>
                <br />
                <br/>

                
              <asp:Button ID="BtnCreateCust" Cssclass="btn btn-lg btn-primary btn-block text-uppercase" runat="server" Text="submit" OnClick="BtnCreateCust_Click" />
              <asp:HyperLink ID="HyperLink4" CssClass="d-block text-center mt-2 small"  runat="server" NavigateUrl="~/LogIn.aspx" >I have an account! I want to Sign In!</asp:HyperLink>
     
                <hr class="my-4"/>
             
          </div>
          </div>
        </div>
      </div>
    </form>

</asp:Content>
