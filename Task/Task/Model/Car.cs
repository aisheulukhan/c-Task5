using System;
using System.Collections.Generic;
using System.Text;

namespace Task.Model
{
    class Car:Vehicle
    {
        public string model;
        public string brand;
        public int fuelCapacity;
        public double fuelFor1Km;
        public double currentFuel;
        public Car()
        {

        }
        public Car(string model, string brand, int fuelCapacity, double fuelFor1Km) 
        {
            this.model = model;
            this.brand = brand;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1Km;
        }
        public Car(string model, string brand, int year, int fuelCapacity, double fuelFor1Km) : base(year)
        {
            this.model = model;
            this.brand = brand;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1Km;
        }
        public Car(string model, string brand, int year, int fuelCapacity, double fuelFor1Km, string color):base(year)
        {
            this.model = model;
            this.brand = brand;
            this.fuelCapacity = fuelCapacity;
            this.fuelFor1Km = fuelFor1Km;
        }
        

        
        public void ShowInfo()
        {
            Console.WriteLine($"Model:{model}   Brand:{brand}    FuelCapacity:{fuelCapacity}   FuelFor1Km:{fuelFor1Km}");
        }
        public void Drive(double km, double fuelFor1Km, double currentFuel)
        {
            double result = currentFuel - (km * fuelFor1Km);
            if (result > 0)
            {
                Console.WriteLine("Avtomobil bu yolu gede biler");
            }
            else
            {
                Console.WriteLine("Avtomobil bu yolu gede bilmez");
            }

            
            
        }
    }
}
