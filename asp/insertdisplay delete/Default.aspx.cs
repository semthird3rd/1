using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection con = new  OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hp\\OneDrive\\Documents\\Visual Studio 2010\\asp\\stud.accdb");

OleDbCommand cmd = new OleDbCommand("insert into stud values('"+TextBox1.Text+"','"+TextBox2.Text+"')",con);

con.Open();
cmd.ExecuteNonQuery();
con.Close();
Response.Write("insert successfully");


    }
protected void  Button2_Click(object sender, EventArgs e)
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hp\\OneDrive\\Documents\\Visual Studio 2010\\asp\\stud.accdb");
    OleDbCommand cmd = new OleDbCommand("select * from stud",con);

con.Open();
OleDbDataReader dr = cmd.ExecuteReader();
GridView1.DataSource = dr;
GridView1.DataBind();
con.Close();

}
protected void Button3_Click(object sender, EventArgs e)
{
    OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\hp\\OneDrive\\Documents\\Visual Studio 2010\\asp\\stud.accdb");
    OleDbCommand cmd = new OleDbCommand("delete from stud where name='" + TextBox1.Text + "'", con);

    con.Open();
    cmd.ExecuteNonQuery();
    con.Close();
    Response.Write("delete successfully");

}
}

