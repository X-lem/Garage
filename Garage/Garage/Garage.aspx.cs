using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garage {
    public partial class Garage : System.Web.UI.Page {

        Panel masterPanel;
        Panel panel;
        TextBox txtBox;
        Button btn;
        int carsInGarage = 0;

        protected void Page_Load(object sender, EventArgs e) {

            if (!IsPostBack) {
                Session["carsInGarage"] = carsInGarage;
            } 


            // Create Master panel
            masterPanel = new Panel();
            masterPanel.CssClass = "Border";

            masterPanel.Controls.Add(AddVehiclePanel());
            serverForm.Controls.Add(masterPanel);

        }

        protected Panel AddVehiclePanel() {

            panel = new Panel();
            panel.CssClass = "addVehiclePanel";

            btn = new Button();
            btn.CssClass = "addVehicleBtn";
            btn.ID = "addVehicleID";
            btn.Text = "Add Vehicle";
            btn.Click += new EventHandler(this.addNewVehicle);

            panel.Controls.Add(btn);
            
            return panel;

        }

        void addNewVehicle(Object sender, EventArgs e) {

            carsInGarage = (int)(Session["carsInGarage"]) + 1;
            Session["carsInGarage"] = carsInGarage;

            panel = new Panel();

            txtBox = new TextBox();
            txtBox.Text = "Testing";

            panel.Controls.Add(txtBox);
            masterPanel.Controls.Add(txtBox);
        }

    }
}