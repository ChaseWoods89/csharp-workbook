using System;
using System.Collections.Generic;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot JimsCars = new CarLot("Jim's Cars");
            Car mazda = new Car(/*car attributes go here*/);
            Car BMW = new Car(/*car attributes go here */);
            Truck F150 = new Truck(/*Truck attributes go here */)
        }

    public class CarLot
    {
        string name;

        public CarLot(string name){

        }
        List<Vehicle> inventory;

        public void Add(Vehicle vehicle){
            //code goes here...
        }
        public void PrintInventory(){
            //code goes here...
        }
    }

    public abstract class Vehicle
    {
        string licenseNumber;
        string make;
        string model;
        string price;


            override
        public String ToString(){
            string s = "";
            return s;
        }
    }

        public class Car : Vehicle{


        }

        public class Truck : Vehicle{

        
    }

}
}

