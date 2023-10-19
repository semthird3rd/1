using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Label4.Text = TextBox1.Text;
        if (RadioButton1.Checked == true)
        {
            Label5.Text = RadioButton1.Text;
        }
        else
        {
            Label5.Text = RadioButton2.Text;
        }
        foreach (ListItem Item in CheckBoxList1.Items)
        {
            if (Item.Selected)
            {
                Label6.Text += Item.Text + "  ";
            }
        }

    }
}