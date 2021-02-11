using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExampleClear
{
    public partial class Index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)
            {
                lab.Text = File.ReadAllText(Server.MapPath("~/app_data/TextFile.txt"));
            }


            Response.Redirect("Google.com");
            

            int count = 0;


            object mycount = ViewState["count"];

            if (mycount !=null)
            {
                count = (int)mycount;
            }
            count += 1;
            ViewState["count"] = count;
     
           
        }

        protected void dtn_Click(object sender, EventArgs e)
        {

        
            for (int i = 0; i < 10000; i++)
            {
                ViewState[i.ToString()] = i;
            }
        }
    }
}