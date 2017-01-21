using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Garage {
    public class Car {

        private static int carID = 0;
        private int VIN;
        private String Manufacture;
        private String Make;
        private int Year;
        private String Color;
        private Array Seating = new Array[6];


        static Car() {

            Car c = new Car();
            carID++;
            c.VIN = carID;
        }


        public int getVIN() {
            return VIN;
        }

        public String getManufacture() {
            return Manufacture;
        }
        public void setManufacture(String x) {
            Manufacture = x;
        }


        public String getMake() {
            return Make;
        }
        public void setMake(String x) {
            Make = x;
        }

        public int getYear() {
            return Year;
        }
        public void setYear(int x) {
            Year = x;
        }

        public Array getSeating() {
            return Seating;
        }
        public void setSeating(Array temp) {
            Array.Copy(temp, Seating, 6);
        }


    }
}