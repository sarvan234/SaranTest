<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="IntegrationServicesWeb.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
    <h2><%: Title %>Contacts &amp; Support </h2>
            <div class="col-md-4">
        <section id="Contacts">
        <h3><strong>Integration CoE -&nbsp; TCS</strong></h3>
    <h4>Developer :</h4> <p>Saravanan Mohan <br /> E-Mail&nbsp; : <a href="mailto:smohan@primark.co.uk">smohan@primark.co.uk</a>&nbsp; &nbsp;</p>
    <h4>Delivery Manager :</h4><p>Subbarao Amara <br /> E-Mail&nbsp; : <a href="mailto:samara@primark.co.uk">samara@primark.co.uk</a>&nbsp; <br /> Ph no : +44 (0) 7438887050</p>
     </section>
        </div>
   <div class="col-md-4">
        <section id="Address">
        <H3><strong>TCS UK Details : </strong></H3>
    <address>
        <span>TCS London - UK &amp; I HQ <br /> 5th Floor,2 Derry Street <br /> London W8 5TT <br />United Kingdom</span><br />
        <a href="mailto:contact.us@tcs.com">contact.us@tcs.com</a> </address>
       </section>
        </div>
</div>
</asp:Content>