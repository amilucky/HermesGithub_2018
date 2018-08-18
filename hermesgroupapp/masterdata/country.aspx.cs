using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using System.Data.SqlClient;
//using System.Configuration;
//using System.Data;


namespace hermesgroupapp.masterdata
{
    public partial class country : System.Web.UI.Page
    {
        //SqlConnection conString = new SqlConnection(ConfigurationManager.ConnectionStrings["firstConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            //conString.Open();
        }

        protected void lbInsert_Click(object sender, EventArgs e)
        {

            masterdata_country.InsertParameters["name"].DefaultValue =
                ((TextBox)GridView.FooterRow.FindControl("txtName")).Text;
            masterdata_country.Insert();

            //String temp;
            //temp = ((TextBox)GridView1.FooterRow.FindControl("txtName")).Text;

            //masterdatacountry.InsertParameters["name"].DefaultValue = temp;
            // insert data - via GridView
            //masterdatacountry.InsertParameters["name"].DefaultValue =
            //    ((TextBox)GridView1.FooterRow.FindControl("txtName")).Text;
            //masterdatacountry.Insert();
            //temp = temp;
        }

    }
}