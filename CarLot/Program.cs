using System;
using System.Collections.Generic;

namespace OOP3 
{

    public class Program {

        public static void Main(String[] args) 
        {
            CarLot CL1 = new CarLot("Chase's Cars");
            Car mazda = new Car("White", "Mazda", "3", "Hatchback");
            Car subaru = new Car("Black", "Subaru", "Impreza", "Sedan");
            Car chevy = new Car("Silver", "Chevy", "Malibu", "Sedan");
            Car toyota = new Car("Green", "Toyota", "Celica", "Coupe");
            Truck f150 = new Truck("Red", "Ford", "F-150", 5);
            Truck titan = new Truck("Gray","Nissan","Titan", 5);
            Truck ram = new Truck("Black", "Dodge", "Ram", 6);
            CL1.Add(mazda);
            CL1.Add(subaru);
            CL1.Add(f150);

            CL1.PrintInventory();
            
        }

    }

    public  class CarLot {
        List<Vehicle> inventory;
        String name;

        public CarLot(string intialName){
            this.name = intialName;           
        }

        public void Add(Vehicle vehicle){
            //code goes here
        }

        public void PrintInventory(){
            foreach(var vehicle in inventory){
                Console.WriteLine(vehicle);
            }
        }
    }

    public abstract class Vehicle {
        
        string color;
        string make;
        string model;

        public Vehicle(string intialColor, string intialMake, string intialModel){
            this.color = intialColor;
            this.make = intialMake;
            this.model = intialModel;
        }

        override
        public String ToString(){
            String s = string.Format(this.color + "" + this.make + "" + this.model + "");
            return s;
        }

    }

    public  class Car : Vehicle{
        
        string bodyType;

        public Car(string initialColor, string initialMake, string intialModel, string intialBodyType) :
        base(initialColor, initialMake, intialModel ){
            this.bodyType = intialBodyType;

        }

        override
        public String ToString(){
            String s = string.Format(this.bodyType);
            return s;
        }

    }

    public class Truck : Vehicle {

        int cabSize; 

        public Truck(string intialColor, string initialMake, string intialModel, int initialCabSize) :
        base(intialColor, initialMake, intialModel){
            this.cabSize = initialCabSize;
        }
    }
}