using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace EinsTask2
{
    public partial class crudform : System.Web.UI.Page
    {
        crudDAL d = new crudDAL();
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        public crudform()
        {
            con = new SqlConnection(ConfigurationManager.ConnectionStrings["defaultconnection"].ConnectionString);
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            getall();
        }

        
        public void getall()
        {
            
            con.Open();
            string qry = "select *from Users";
            cmd = new SqlCommand(qry, con);

            reader = cmd.ExecuteReader();
            DataTable t = new DataTable();
            t.Load(reader);
            GridView1.DataSource = t;
            GridView1.DataBind();

        }

        protected void savebtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = nametxt.Text;
            u.Address = addresstxt.Text;
            u.State = DropDownList1.SelectedValue;
            u.City = citytxt.Text;
            u.Age = Convert.ToInt32(agetxt.Text);
            int res = d.Add(u);
            if(res == 1)
            {
                Response.Write("Record inserted Sucessfully");
                nametxt.Text = " ";
                addresstxt.Text = " ";
                citylbl.Text = " ";
                agetxt.Text = " ";
            }
            else
            {
                Response.Write("Something Wrong");
            }
        }

        protected void updatebtn_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = nametxt.Text;
            u.Address = addresstxt.Text;
            u.State = DropDownList1.SelectedValue;
            u.City = citytxt.Text;
            u.Age = Convert.ToInt32(agetxt.Text);
            u.Id = Convert.ToInt32(idtxt.Text);
            int res = d.Update(u);
            if(res == 1)
            {
                Response.Write("Updated Sucessfully");
            }
            else
            {
                Response.Write("something wrong");
            }

        }
    }
}