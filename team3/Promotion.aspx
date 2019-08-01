<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="Promotion.aspx.cs" Inherits="team3.Promotion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            width: 180px;
            height: 140px;
            image-orientation:;
        }
      
        body
        {
            background-image: url('images/Endownment BG.jpg');
              background-repeat:no-repeat;
               background-position: center;
                background-size: cover;
        }
       
       .responsive
        {
          width: 90%;
          max-width: 90px;
          height: 75px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

    <form id="form1" runat="server">
   <div class ="container">
       <br/>
       <h1>Promotions:</h1>
       <br />
       <br />
       <h4>
           <asp:Label ID="Label1" runat="server" Text="Insurance Promotions:">
           </asp:Label>

       </h4>
        <div class="form-row">
            <div class="form-group">
                <div class="col-lg-3 col-md-3 col-sm-5">
                    <div class="card" style="width: 18rem;">
                        <img src="images/Endownment%20Promo%201%20.jpg" class="card-img-top" />
                        <div class="card-body">
                        <h5 class="card-title">Endownment Plan Promotion</h5>
                          <p class="card-text">From now till 30 Nov 2019, create an endownment plan to enjoy a 3.9% of interest rate till maturity
                              <br/> 
                              <br/>
                              
                          
                              Click here to view the product :

                          </p>
                            <asp:Button ID="Button2" runat="server" cssclass="btn btn-primary" Text="Go Endownment!" />
                                
                        </div>
                    </div>
                </div>
            </div>
         

             <div class="form-group">
                 <div class="col-lg-3 col-md-3 col-sm-5">
                    <div class="card" style="width: 18rem;">
                         <img src="images/Travel%20Promo.jpg" class="card-img-top"/>
                         <div class="card-body">
                            <h5 class="card-title">Travel insurance Promotion</h5>
                            <p class="card-text"> From now till 31 Dec 2019, enjoy 20% off for your travel insurance for the following destination: Malaysia, Thailand or Indonesia
                                  <br/> 
                                  <br/>
                                  <br/>
                                  
                             Click here to view the product :
                            </p>
                             <asp:Button ID="Button1" runat="server" cssclass="btn btn-primary" Text="Go Travel!" />
                             
                                  <br />
                         </div>
                    </div>
                </div>
             </div>
           
             <div class="form-group">
                 <div class="col-lg-3 col-md-3 col-sm-5">
                    <div class="card" style="width: 18rem;">
                         <img src="images/Health%20Promo.png" class="card-img-top" />
                         <div class="card-body">
                            <h5 class="card-title">Health insurance Promotion</h5>
                                <p class="card-text">From now till 30 Aug 2019, Subscribe to our Health insurance promotion plan and get the first year subscription FREE!
                                    <br />
                                    <br />
                                     Click here to view the product :
                                </p>
                             <asp:Button ID="Button3" runat="server" cssclass="btn btn-primary" Text="Go Health!" />
                         </div>
                    </div>
                </div>
             </div>
        </div>
       <br />
       <br />
       
       
       <h4>           
           <asp:Label ID="Label2" runat="server" Text="GoWallet Deals:" ForeColor="White"></asp:Label>
       </h4>
       <br />
         <div class="form-row">
          
             <div class="form-group">
                 <div class="col-lg-3 col-md-3 col-sm-5">
                    <div class="card" style="width: 18rem;">
                         <img src="images/Zalora%20Logo.png" class="card-img-top"/>
                         <div class="card-body">
                            <h5 class="card-title">Enjoy $8 off for your first order in Zalora (Min spending of $15)</h5>
                            <p class="card-text"> From now till 31 December 2019, apply this promocode: <strong>GoZalora8</strong> with minimum spending of $15
                                                  Promotion is only valid for new Zalora user only!
                                                  For more terms conditions, visit <br /><span class="text-primary">ZaloraSG</span>

                            </p>
                            
                         </div>
                    </div>
                </div>
             </div>
            
            
             <div class="form-group">
                 <div class="col-lg-3 col-md-3 col-sm-5">
                    <div class="card" style="width: 18rem;">
                         <img src="images/Grab%20Logo.png" class="card-img-top" />
                         <div class="card-body">
                            <h5 class="card-title">Grab</h5>
                            <p class="card-text">Get up to 30% on Grab when you pay with GoWallet: From now till 30 November 2019,
                                 apply this promocode:<strong>GoWithGrab30</strong> to enjoy 30% discount for your ride. Discount capped is $3.For
                                 more terms conditions, visit<span class="text-primary">GrabSG!</span> 
                           
                            </p>
                   
                         </div>
                    </div>
                </div>
             </div>
        </div>


            
  </div>
 
 

    </form>

</asp:Content>
