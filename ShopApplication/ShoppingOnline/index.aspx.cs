using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel.Web;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class index : System.Web.UI.Page
{

    private SqlConnection conn = new SqlConnection();
    private SqlDataReader dr;


    protected void Page_Load(object sender, EventArgs e)
    {

        dr = null;
        conn.ConnectionString = @"Data Source=DANILO-PC\SQLEXPRESS;Initial Catalog=OfflineShop;Integrated Security=True";

    }



    [WebInvoke(UriTemplate = "test", Method = "POST", ResponseFormat = WebMessageFormat.Json)]
    public string test(Object data)
    {
        return "DANILO WINNER";
    }


}