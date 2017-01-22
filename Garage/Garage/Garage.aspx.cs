using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Garage {
    public partial class Garage : System.Web.UI.Page {

        Panel masterPanel;
        Panel parkingSpot;
        Panel panel;
        TextBox txtBox;
        Button btn;
        int carsInGarage = 0;
        List<Car> garage = new List<Car>();

        protected void Page_Load(object sender, EventArgs e) {

            // Create session variable
            if (!IsPostBack) {
                Session["garageList"] = garage;
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

            // Obtain list from session
            garage = (List<Car>)Session["garageList"];

            // Add new car to list
            Car car = new Car();
            garage.Add(car);

            // Create panel to hold car description
            parkingSpot = new Panel();
            parkingSpot.ID = "car" + car.getVIN().ToString();
            parkingSpot.CssClass = "singleParking";


            // Create Header to parkingSpot
            parkingSpot.Controls.Add(carHeader());



            panel.Controls.Add(txtBox);
            masterPanel.Controls.Add(txtBox);

            // Add everything to
            masterPanel.Controls.Add(parkingSpot);
        }

        // For newly created cars
        Panel carHeader() {
            panel = new Panel();




            return panel;
        }


        // For previously created cars
        Panel carHeader(List<Car> garage) {
            panel = new Panel();


            return panel;
        }


        void addOldVehicles() {

            
        }

    }
}