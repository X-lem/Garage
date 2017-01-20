using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage {
    public class Car {

        private String Manufacture;
        private String Make;
        private int Year;
        private String Color;
        private Array Seating = new Array[6];


        public String getManufacture() {
            return Manufacture;
        }
        public void updateManufacture(String x) {
            Manufacture = x;
        }


        public String getMake() {
            return Make;
        }
        public void updateMake(String x) {
            Make = x;
        }

        public int getYear() {
            return Year;
        }
        public void updateYear(int x) {
            Year = x;
        }

        public Array getSeating() {
            return Seating;
        }
        public void updateSeating(Array temp) {
            Array.Copy(temp, Seating);
        }


    }
}