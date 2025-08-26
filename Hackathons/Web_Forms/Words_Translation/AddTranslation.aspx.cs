using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class AddTranslation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            if(Session["CurrentWord"] != null)
        {
                lblWord.Text = "Word: " + Session["CurrentWord"].ToString();
            }


        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            string word = Session["CurrentWord"].ToString();
            string translation = txtTranslation.Text.Trim();
            WordStore.UpdateTranslation(word, translation);
            Response.Redirect("MyWords.aspx");

        }
    }
}