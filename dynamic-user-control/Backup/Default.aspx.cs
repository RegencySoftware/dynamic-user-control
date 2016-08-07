using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicUC
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// You must add the users controls in the INIT. If you attempt on page load you will not have
        /// access to any of the control methods.
        /// 
        /// 1. The first time the page loads loads the controls from the database
        /// 2. On all other page loads just load the control back on the page but retain user entered values
        /// </summary>
        private void Page_Init(object sender, EventArgs e)
        {
            //Pass true (Not Postback) on the first load to
            //indicate to load the control from the databasde. 
            AddControlToPage(!Page.IsPostBack, "ford");
            AddControlToPage(!Page.IsPostBack, "chevy");
            AddControlToPage(!Page.IsPostBack, "dodge");
            
        }
        /// <summary>
        /// Load an instance of the user control to the page
        /// </summary>
        /// <param name="loadFromDatabase">based on post back</param>
        /// <param name="maker">auto maker name</param>
        private void AddControlToPage(bool loadFromDatabase, string maker)
        {
            DynamicUC.Controls.AutoSurvey UC = (DynamicUC.Controls.AutoSurvey)LoadControl("~/Controls/AutoSurvey.ascx");
            UC.SetupControl(loadFromDatabase, maker);

            //Add the instance of the control to the page.
            PHUserControl.Controls.Add(UC);
        }
        /// <summary>
        /// Save does nothing at this point. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSave_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("<b><u>Your Entries</u></b>");
            sb.Append("<br />");

            //Get the values of each instance and show on the page.
            foreach (Control ctl in PHUserControl.Controls)
            {
                if (ctl is DynamicUC.Controls.AutoSurvey)
                {
                    DynamicUC.Controls.AutoSurvey UC = (DynamicUC.Controls.AutoSurvey)ctl;
                    sb.Append(" * " + UC.Model + " " + UC.Comments);
                    sb.Append("<br />");
                }
            }

            LblMsg.Text = sb.ToString();
        }
    }
}
