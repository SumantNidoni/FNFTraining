using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class TranslationApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            WordStore.Initialize();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {



            string word = txtWord.Text.Trim().ToLower();
            Session["CurrentWord"] = word;

            if (!WordStore.Contains(word))
            {
                WordStore.UpdateTranslation(word, null);
                Response.Redirect("AddTranslation.aspx");
            }
            else if (!WordStore.Istranslated(word))
            {
                Response.Redirect("AddTranslation.aspx");
            }
            else
            {
                Response.Redirect("MyWords.aspx");
            }

        }


    }
}