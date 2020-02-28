using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace IntegrationServicesWeb
{
    public partial class Home : System.Web.UI.Page
    {
        string connectionString = @"Data Source=IEDU1WVDSQL002;Persist Security Info=True;User ID=ESBCOE_RO;Password=Primark2020!";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindGridView(); //bindgridview will get the data source and bind it again
        }

        public void BindGridView()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("SELECT INTERFACE_ID, INTERFACENAME, AUDIT_TIMESTAMP, AUDITTYPE, MSGFLOW, MESSAGEID FROM ESB_AUDIT_LOGGER WHERE INTERFACENAME = @INTNAME AND  (AUDIT_TIMESTAMP BETWEEN @AUDIT_STARTDATE AND @AUDIT_ENDDATE)", con);
            cmd.Parameters.Add("@INTNAME", SqlDbType.NVarChar);
            cmd.Parameters["@INTNAME"].Value = DropDownList1.SelectedValue;


            cmd.Parameters.Add("@AUDIT_STARTDATE", SqlDbType.DateTime2);
            cmd.Parameters["@AUDIT_STARTDATE"].Value = txtStartDate.Text;

            cmd.Parameters.Add("@AUDIT_ENDDATE", SqlDbType.DateTime2);
            cmd.Parameters["@AUDIT_ENDDATE"].Value = txtEndDate.Text;


            SqlDataAdapter Adpt = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Adpt.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            BindGridView();
        }
    }
    }