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
        int carVin;
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
            parkingSpot.ID = "car" + car.getVIN();
            parkingSpot.CssClass = "singleParking";

            carVin = car.getVIN();

            // Create Header to parkingSpot
            parkingSpot.Controls.Add(carHeader());
            parkingSpot.Controls.Add(carSeating());

            // Add everything to masterPanel
            masterPanel.Controls.Add(parkingSpot);
            addOldVehicles();
        }

        // For newly created cars
        private Panel carHeader() {
            panel = new Panel();

            txtBox = new TextBox();
            txtBox.CssClass = "yearClass";
            txtBox.ID = "year" + carVin;
            panel.Controls.Add(txtBox);

            txtBox = new TextBox();
            txtBox.CssClass = "makeClass";
            txtBox.ID = "make" + carVin;
            panel.Controls.Add(txtBox);

            txtBox = new TextBox();
            txtBox.CssClass = "modelClass";
            txtBox.ID = "model" + carVin;
            panel.Controls.Add(txtBox);
            

            return panel;
        }

        private Panel carSeating() {

            Panel panel = new Panel();
            panel.CssClass = "seatHolder";

            // Seating
            // ID_carVin_ArrayIndex
            for (int i = 0; i < 5; i++) {
                txtBox = new TextBox();
                txtBox.CssClass = "seat";
                txtBox.ID = "seat_" + carVin + "_" + i;
                panel.Controls.Add(txtBox);
            }

            return panel;
        }


        void addOldVehicles() {




            garageForm.Controls.Add(masterPanel);
        }

    }
}