﻿using System;
using System.Collections.Generic;

namespace OOP3 
{

    public class Program {

        public static void Main(String[] args) 
        {
            CarLot CL1 = new CarLot("Chase's Cars");
            CarLot CL2 = new CarLot("Other guys' Cars");
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
            CL2.Add(toyota);
            CL2.Add(titan);
            CL2.Add(ram);

            CL1.PrintInventory();
            CL2.PrintInventory();
            
        }

    }

    public  class CarLot {
        List<Vehicle> inventory;
        String name;

        public CarLot(string intialName){
            this.name = intialName;           
        }

        public void Add(Vehicle vehicle){
            inventory.Add(vehicle);
        }

        public void PrintInventory(){
            foreach(var vehicle in inventory){
                Console.WriteLine(vehicle.ToString());
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
            String s1 = string.Format(this.color + "" + this.make + "" + this.model + "");
            return s1;
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
            String s2 = string.Format(this.bodyType);
            return s2;
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