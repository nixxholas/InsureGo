<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="LogIn.aspx.cs" Inherits="team3.LogIn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
        body
{
    background-image: url('images/Sign in.jpg');
      background-repeat:no-repeat;
       background-position: center;
        background-size: cover;

}
    
        .card-signin {
  border: 0;
  border-radius: 1rem;
  box-shadow: 0 0.5rem 1rem 0 rgba(0, 0, 0, 0.1);
}

.card-signin .card-title {
  margin-bottom: 2rem;
  font-weight: 300;
  font-size: 1.5rem;
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
    .auto-style1 {
        position: relative;
        margin-bottom: 0;
        vertical-align: top;
        left: 0px;
        top: 0px;
        height: 30px;
    }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <form class="form-signin" runat="server">
    <div class="container">
    <div class="row">
      <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
        <div class="card card-signin my-5">
          <div class="card-body">
              <asp:Label ID="LblErr" runat="server" ForeColor="Red" Text="" Visible="false"></asp:Label>
              <br />
            <h2 class="card-title text-center">InsureGo</h2>
            
              <div class="form-label-group">
                  <asp:Label ID="NRIC" runat="server" Text="NRIC"></asp:Label>
             <asp:TextBox ID="tbNRIC" CssClass ="form-control " runat="server" Width="382px" placeholder="NRIC" style="margin-top: 0" required Height="33px" ></asp:TextBox>
                </div>

              <div class="form-label-group">
                  <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
                 <asp:TextBox ID="tbPassword" TextMode="Password" CssClass ="form-control " runat="server" placeholder="Password" style="margin-bottom: 0" Width="380px" required Height="33px"></asp:TextBox>
                   </div>

              <div class="custom-control custom-checkbox mb-3" style="left: 0px; top: 0px">
               <asp:CheckBox ID="customCheck1" runat="server" Cssclass="custom-control-input" />
               
                <label class="auto-style1" for="customCheck1">Remember password</label>
              </div>
              
              <asp:Button ID="BtnSignIn" CssClass="btn btn-lg btn-primary btn-block text-uppercase" runat="server" Text="Sign In" OnClick="BtnSignIn_Click1" />
              <hr class="my-4"/>
              <br />
              
              <asp:HyperLink ID="HyperLink4" CssClass="d-block text-center mt-2 small"  runat="server" NavigateUrl="~/SignUp.aspx" >Dont have an account? Sign up here!</asp:HyperLink>
              
          </div>
        </div>
      </div>
    </div>
  </div>
         </form>

</asp:Content>
