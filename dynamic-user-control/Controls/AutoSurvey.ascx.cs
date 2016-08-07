using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DynamicUC.Controls
{
    public partial class AutoSurvey : System.Web.UI.UserControl
    {
        #region Public Properties
        public string Comments
        {
            get
            {
                return TxtComments.Text;
            } 
        }

        public string Model
        {
            get
            {
                return DDLAutos.SelectedValue;
            }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Called from the parent page
        /// </summary>
        public void SetupControl(bool loadFromDatabase, string maker)
        {
            //Add the DDL values each time. On post backs it will 
            //retain the last item selected.
            switch (maker)
            {
                case "ford":
                    PnlAuto.GroupingText = "Ford Cars";
                    DDLAutos.Items.Add("Focus");
                    DDLAutos.Items.Add("Mustang");
                    DDLAutos.Items.Add("Fusion");
                    break;
                case "chevy":
                    PnlAuto.GroupingText = "Chevy Cars";
                    DDLAutos.Items.Add("Camaro");
                    DDLAutos.Items.Add("Corvette");
                    DDLAutos.Items.Add("Impala");
                    break;
                case "dodge":
                    PnlAuto.GroupingText = "Dodge Cars";
                    DDLAutos.Items.Add("Avenger");
                    DDLAutos.Items.Add("Caliber");
                    DDLAutos.Items.Add("Challenger");
                    break;
            }

            //Simulate loading data from the DB on the first load
            if (loadFromDatabase)
            {
                DDLAutos.Items.Add("Select");
                //DDLAutos.SelectedIndex = DDLAutos.Items.Count - 1;

                DDLAutos.SelectedIndex = 1;
                TxtComments.Text = "DB comments -  " + DDLAutos.SelectedValue.ToString();
            }
        }       
    }
}