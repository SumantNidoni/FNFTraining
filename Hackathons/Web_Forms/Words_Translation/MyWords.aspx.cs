using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SampleWebFormsApp
{
    public partial class MyWords : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                gvWords.DataSource = WordStore.GetTranslatedWords();
                gvWords.DataBind();
            }


        }
    }
}