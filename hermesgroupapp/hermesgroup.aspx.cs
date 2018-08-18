using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace hermesgroupapp
{
    public partial class hermesgroup : System.Web.UI.Page
    {
        //to use trusted/encrypted connection
        //SqlConnection conString = new SqlConnection(@"Data Source=hermesgroupserver.database.windows.net;Initial Catalog=first;Persist Security Info=True;User ID=ServerAdmin;Password=Hermes1234");
        SqlConnection conString = new SqlConnection(ConfigurationManager.ConnectionStrings["firstConnectionString"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            conString.Open();
            //LinkButton LinkButton1 = new LinkButton();
            //LinkButton1.Click += new EventHandler(LinkButton1_Click);

        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            // insert data - via GridView
            BrandsSource.InsertParameters["name"].DefaultValue =
                ((TextBox)GridView1.FooterRow.FindControl("txtBrand")).Text;
            BrandsSource.Insert();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Label1.Text = "Hello";

            // display data
            if (conString.State == ConnectionState.Closed) 
                conString.Open();

            SqlCommand cmd = new SqlCommand("select [id], [name] from [dbo].[Brands]", conString);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conString;

            string temp = "";
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                temp += reader["id"].ToString();
                temp += reader["name"].ToString();
                temp += "<br/>";
            }

            Label1.Text = temp;

            conString.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            // insert data - via SqlCommand
            if (conString.State == ConnectionState.Closed) 
                conString.Open();
            SqlCommand cmd = new SqlCommand("prcBrandsInsert", conString);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", TextBox1.Text.Trim());
            cmd.ExecuteNonQuery();
            conString.Close();
            
        }
    }
}