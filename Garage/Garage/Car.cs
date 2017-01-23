using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage {
    public class Car {

        private static int carID = 0;
        private int VIN;
        private String Make; // Manufacturer
        private String Model;
        private int Year;
        private String Color;
        //private string[] Seating = new string[6];


        public Car() {

            carID++;
            VIN = carID;
        }


        public int getVIN() {
            return VIN;
        }

        public String getMake() {
            return Make;
        }
        public void setMake(String x) {
            Make = x;
        }


        public String getModel() {
            return Model;
        }
        public void setModel(String x) {
            Model = x;
        }

        public int getYear() {
            return Year;
        }
        public void setYear(int x) {
            Year = x;
        }

        public string getColor() {
            return Color;
        }

        public void setColor(String x) {
            Color = x;
        }


        //public Array getSeating() {
        //    return Seating;
        //}
        //public void setSeating(Array temp) {
        //    Array.Copy(temp, Seating, 6);
        //}


    }
}