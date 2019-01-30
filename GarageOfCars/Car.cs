/*******************************************************************************
*  APPLICATION :    Car.cs
*  PURPOSE     :    Creates Car with model, type, year and engine parameters
*  AUTHOR      :    Kedar Kanel 
*  Date        :   12 Feb 2014
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class Car
    {
        string nameOfCar;
        string model;
        string type;
        int year;
        double engine;

        public Car() { }
        public Car(string name, string mdl, string typ, int yr, double eng) { 
            //Console.WriteLine("New car created");
            this.nameOfCar = name;
            model = mdl;
            type = typ;
            year = yr;
            engine = eng;
        }

        public string getCarName()
        {
            return nameOfCar;
        }
        public string getCarModel()
        {
            return model;
        }
        public string getCarType()
        {
            return type;
        }
        public int getCarYear()
        {
            return year;
        }
        public double getCarEngine()
        {
            return engine ;
        }
    }
}
