<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="IntegrationServicesWeb.Home" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<script type="text/javascript" src="Scripts/jquery.min.js"></script>
<script type="text/javascript" src="Scripts/moment.min.js"></script>
<script type="text/javascript" src="Scripts/daterangepicker.min.js"></script>
<link rel="stylesheet" type="text/css" href="Content//daterangepicker.css" />
    <script>
        $(function () {
            $("#<%= txtStartDate.ClientID %>").daterangepicker({
                singleDatePicker: true,
                timePicker: true,
                timePicker24Hour: true,
                locale: {
                    format: 'DD/MM/YYYY HH:mm'
                }
            });
        });
</script>
        <script>
            $(function () {
                $("#<%= txtEndDate.ClientID %>").daterangepicker({
                    singleDatePicker: true,
                    timePicker: true,
                    timePicker24Hour: true,
                    locale: {
                        format: 'DD/MM/YYYY HH:mm'
                    }
                });
            });
</script>

    <p></p>
    <div class="row">
        <h2>Give Inputs and Click Update for Different View</h2>
            <div class="col-md-6">
        <h2>Field Descrptions</h2>
        <ul>
            <li>Interface ID - Primark Integration interface id</li>
            <li>Start Time - Bounded start time to view the audit data</li>
            <li>End Time - End time for the bounded search</li>
            <li>String Search - Unique fields for the interface Eg: Store number, FileName etc.. - Not mandatory - Leave blank if unsure</li>
        </ul>
    </div>
        <p></p>
    <div class="col-md-2">
        <p>
            <asp:Label ID="Label1" runat="server" BorderStyle="None" Height="27px" ToolTip="Interface NAme " Width="121px">Interface Name</asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" BorderStyle="None" Height="27px" ToolTip="Start Time for Search" Width="121px">Start Date & Time</asp:Label>
        </p>
        <p><asp:Label ID="Label3" runat="server" BorderStyle="None" Height="27px" ToolTip="Interface NAme " Width="121px">End Date & Time</asp:Label></p>
        <p><asp:Label ID="Label4" runat="server" BorderStyle="None" Height="27px" ToolTip="Interface NAme " Width="121px">String Search</asp:Label></p>
        <p></p>
    </div>
    <div class="col-md-3">
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="PID" Height="23px" Width="227px" DataTextField="INTERFACENAME" DataValueField="INTERFACENAME">
            </asp:DropDownList>
            <asp:SqlDataSource ID="PID" runat="server" ConnectionString="<%$ ConnectionStrings:ESBDB %>" SelectCommand="SELECT DISTINCT [INTERFACENAME] FROM [ESB_AUDIT_LOGGER]"></asp:SqlDataSource>
        </p>
        <p>
  
 <asp:TextBox ID="txtStartDate"  runat="server"  Width="225px" AutoPostBack="False"  TabIndex="1" placeholder="dd/mm/yyyy" autocomplete="off" MaxLength="10"></asp:TextBox>
 <%--<asp:CompareValidator ID="CompareValidator1" runat="server"  ControlToValidate="txtStartDate"   Operator="DataTypeCheck"  Type="Date">Date invalid, please check format.  </asp:CompareValidator>--%>

</p>
        <p>
<asp:TextBox ID="txtEndDate" runat="server" Width="225px" AutoPostBack="False" TabIndex="1"  placeholder="dd/mm/yyyy" autocomplete="off" MaxLength="10"></asp:TextBox>
<%-- <asp:CompareValidator ID="CompareValidator2" runat="server"  ControlToValidate="txtEndDate" Operator="DataTypeCheck" Type="Date">Date invalid, please check format. 
 </asp:CompareValidator>--%>
        </p>
        <p><asp:TextBox ID="MsgID" Height="23px" Width="227px" runat="server">795</asp:TextBox></p>
    </div>
        <div class="row navbar-right">
            <asp:Button ID="Submit" runat="server" Text="Refresh Dashboard" Class="btn btn-primary" BorderStyle="Outset" Height="34px" Width="152px" OnClick="Submit_Click"/>
        </div>
     </div>
        <div class="row">
           <p>
               <asp:GridView ID="GridView1" runat="server" EmptyDataText="No Data Available" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging" >  
        </asp:GridView>  
               </p>
    </div>
</asp:Content>