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
        HttpBrowserCapabilities K; 
        K = Request.Browser;
        Response.Write("<h1>Browser Information And Capabilities</h1>");
        Response.Write("Browser Name is :-" + K.Browser + "<br>"); 
        Response.Write("Browser Version is :-" + K.Version + "<br>"); 
        Response.Write("Browser Support to tables:-" + K.Tables + "<br>");
        Response.Write("Browser Support to JavaScript :-" + K.JavaScript +"<br>");
        Response.Write("Browser Support to VBScript :-" + K.VBScript + "<br>");
        Response.Write("Browser Support to Frames :-" + K.Frames + "<br>"); 
        Response.Write("Browser Support to BackGround Sound :-" + K.BackgroundSounds + "<br>");
        Response.Write("Browser Support to Cookies :-" + K.Cookies + "<br>");
        Response.Write("Browser ID is :-" + K.Id + "<br>"); 
        Response.Write("Browser PlatForm is :-" + K.Platform +"<br>");

    }
}