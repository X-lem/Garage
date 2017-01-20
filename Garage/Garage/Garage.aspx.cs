using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garage {
    public partial class Garage : System.Web.UI.Page {

        Panel panel;

        protected void Page_Load(object sender, EventArgs e) {


            panel = new Panel();
            panel.CssClass = "Border";
            this.Controls.Add(panel);

        }
    }
}