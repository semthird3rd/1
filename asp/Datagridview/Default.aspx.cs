using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hp\\OneDrive\\Documents\\Visual Studio 2010\\asp\\stud.accdb");
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        OleDbCommand cmd = new OleDbCommand("insert into stud values('" + TextBox1.Text + "','" + TextBox2.Text + "')", con);
        cmd.ExecuteNonQuery();
        con.Close();
       // Response.Write("<script LANGUAGE='JavaScript'>alert('Data insert sucessfully...!')</script>");
        Response.Write("insert sucessfully");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        DataTable dt = new DataTable();
        con.Open();
        OleDbDataAdapter da = new OleDbDataAdapter("select * from stud", con);
        da.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
        con.Close();

    }
}



