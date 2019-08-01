<%@ Page Title="" Language="C#" MasterPageFile="~/InsureGo.Master" AutoEventWireup="true" CodeBehind="GoWallet.aspx.cs" Inherits="team3.GoWallet" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style>
<link href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css" rel="stylesheet">
<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
.card {
    padding-top: 20px;
    margin: 10px 0 20px 0;
    background-color: rgba(214, 224, 226, 0.2);
    border-top-width: 0;
    border-bottom-width: 2px;
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    -webkit-box-shadow: none;
    -moz-box-shadow: none;
    box-shadow: none;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card .card-heading {
    padding: 0 20px;
    margin: 0;
}

.card .card-heading.simple {
    font-size: 20px;
    font-weight: 300;
    color: #777;
    border-bottom: 1px solid #e5e5e5;
}

.card .card-heading.image img {
    display: inline-block;
    width: 46px;
    height: 46px;
    margin-right: 15px;
    vertical-align: top;
    border: 0;
    -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    border-radius: 50%;
}

.card .card-heading.image .card-heading-header {
    display: inline-block;
    vertical-align: top;
}

.card .card-heading.image .card-heading-header h3 {
    margin: 0;
    font-size: 14px;
    line-height: 16px;
    color: #262626;
}

.card .card-heading.image .card-heading-header span {
    font-size: 12px;
    color: #999999;
}

.card .card-body {
    padding: 0 20px;
    margin-top: 20px;
}

.card .card-media {
    padding: 0 20px;
    margin: 0 -14px;
}

.card .card-media img {
    max-width: 100%;
    max-height: 100%;
}

.card .card-actions {
    min-height: 30px;
    padding: 0 20px 20px 20px;
    margin: 20px 0 0 0;
}

.card .card-comments {
    padding: 20px;
    margin: 0;
    background-color: #f8f8f8;
}

.card .card-comments .comments-collapse-toggle {
    padding: 0;
    margin: 0 20px 12px 20px;
}

.card .card-comments .comments-collapse-toggle a,
.card .card-comments .comments-collapse-toggle span {
    padding-right: 5px;
    overflow: hidden;
    font-size: 12px;
    color: #999;
    text-overflow: ellipsis;
    white-space: nowrap;
}

.card-comments .media-heading {
    font-size: 13px;
    font-weight: bold;
}

.card.people {
    position: relative;
    display: inline-block;
    width: 170px;
    height: 300px;
    padding-top: 0;
    margin-left: 20px;
    overflow: hidden;
    vertical-align: top;
}

.card.people:first-child {
    margin-left: 0;
}

.card.people .card-top {
    position: absolute;
    top: 0;
    left: 0;
    display: inline-block;
    width: 170px;
    height: 150px;
    background-color: #ffffff;
}

.card.people .card-top.green {
    background-color: #53a93f;
}

.card.people .card-top.blue {
    background-color: #427fed;
}

.card.people .card-info {
    position: absolute;
    top: 150px;
    display: inline-block;
    width: 100%;
    height: 101px;
    overflow: hidden;
    background: #ffffff;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.people .card-info .title {
    display: block;
    margin: 8px 14px 0 14px;
    overflow: hidden;
    font-size: 16px;
    font-weight: bold;
    line-height: 18px;
    color: #404040;
}

.card.people .card-info .desc {
    display: block;
    margin: 8px 14px 0 14px;
    overflow: hidden;
    font-size: 12px;
    line-height: 16px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.people .card-bottom {
    position: absolute;
    bottom: 0;
    left: 0;
    display: inline-block;
    width: 100%;
    padding: 10px 20px;
    line-height: 29px;
    text-align: center;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.hovercard {
    position: relative;
    padding-top: 0;
    overflow: hidden;
    text-align: center;
    background-color: rgba(214, 224, 226, 0.2);
}

.card.hovercard .cardheader {
    background: url("http://lorempixel.com/850/280/nature/4/");
    background-size: cover;
    height: 135px;
}

.card.hovercard .avatar {
    position: relative;
    top: -50px;
    margin-bottom: -50px;
}

.card.hovercard .avatar img {
    width: 100px;
    height: 100px;
    max-width: 100px;
    max-height: 100px;
    -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    border-radius: 50%;
    border: 5px solid rgba(255,255,255,0.5);
}

.card.hovercard .info {
    padding: 4px 8px 10px;
}

.card.hovercard .info .title {
    margin-bottom: 4px;
    font-size: 24px;
    line-height: 1;
    color: #262626;
    vertical-align: middle;
}

.card.hovercard .info .desc {
    overflow: hidden;
    font-size: 12px;
    line-height: 20px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.hovercard .bottom {
    padding: 0 20px;
    margin-bottom: 17px;
}

.btn{ border-radius: 50%; width:32px; height:32px; line-height:18px;  }
        .auto-style1 {
            width: 329px;
            height: 140px;
        }
        .auto-style2 {
            left: -15px;
            top: 46px;
        }
         </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Content" runat="server">

     <form id="form1" runat="server">
<div class="container">
	<div class="row">
        <div class="col-lg-3 col-sm-6">
         </div> 
		<div class="auto-style2">

            <div class="card hovercard">
                <div class="cardheader">

                </div>
                <div class="avatar">
                    <img alt="Profile" src="images/user profile.png" class="auto-style1"/>
                </div>
                <div class="info" runat="server">
                    
                    <h2>
                    <asp:Label ID="LbGreeting" runat="server"></asp:Label>
                    </h2>
                    <br />
                    <h1>
 
                        <asp:Label ID="Balance" runat="server" Text="$200.64"></asp:Label>
                   </h1>
                    <br />

                    <p>
                        
                        <br />
                        <asp:DropDownList ID="DropDownList1" runat="server" Width="280px">
                            <asp:ListItem Selected="True">Select merchant</asp:ListItem>
                            <asp:ListItem>Zalora</asp:ListItem>
                            <asp:ListItem>Grab</asp:ListItem>
                            <asp:ListItem>Qoo10</asp:ListItem>
                            <asp:ListItem>Insurego</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <asp:Label ID="Label4" runat="server" Text="Amount"></asp:Label>
                        <asp:TextBox ID="tbPay" runat="server"></asp:TextBox>
                   
                        <br />
                         <asp:Button ID="BtnPay" Cssclass="btn-primary" runat="server" Text="Pay Now" Width="299px" OnClick="BtnPay_Click"  />
                    </p>
                    <p>
                        
                       
                       

                    </p>
                    <hr />

                   <asp:Label ID="Label1" runat="server" Text="Top up amount:"></asp:Label>
                    <br />
                    <asp:TextBox ID="TBTopUp" runat="server" Width="301px"></asp:TextBox>
                    <br />
                    <asp:Button ID="BtnTopUp" CssClass="btn-success" runat="server" Text="Top Up Now!" Width="309px" OnClick="BtnTopUp_Click" />
                    <br />
                    <br />
                    <br />
                    <br />              
                     <asp:Label ID="Label3" runat="server" Text="Send back amount:"></asp:Label>
                    <br />
                    <asp:TextBox ID="tbSendBk" runat="server" Width="297px"></asp:TextBox>
                    <br />
                    <asp:Button ID="BtnSendBack" Cssclass="btn-primary" runat="server" Text="Send Back to bank account" Width="313px" OnClick="BtnSendBank_Click" />
                    <br />
                    <br />
                    <br />
                    <br />
                </div>
                <div class="bottom">
                    
                </div>
            </div>

        </div>
          <div class="col-lg-3 col-sm-6">
              </div>
	</div>

    
 </div>
 </form>

</asp:Content>
