using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Car c1 = new Car("Black", "VW", "Jetta");
            //Console.WriteLine("c1 = {0}" ,c1.ToString());

            Car c2 = new Car("Blue", "Mazda", "3");
            //Console.WriteLine("c2 = {0}", c2.ToString());

            ParkingGarage p1 = new ParkingGarage(7);
            
            p1.ParkCar(c1, 1);
            p1.towCar(1);
            p1.ParkCar(c2, 1);
            Console.WriteLine("Is slot 1 empty? {0}" , p1.isSlotAvailable(1));
            */
            ParkingGarage parkingGarage = null;
            while(parkingGarage == null){

            try{
                Console.WriteLine("Enter the size of your parking garage.");
                string userInput = Console.ReadLine();
                int sizeOfGarage = Convert.ToInt32(userInput);
                parkingGarage = new ParkingGarage(sizeOfGarage);
            } catch{
                Console.WriteLine("Bad size, try again.");
            }
            }
            Console.WriteLine("Your garage has a size of " + parkingGarage.numSpaces);

            Console.WriteLine("What do you want to do?");
            String userInput = Console.ReadLine();
            while(userInput != "Quit"){
                if(userInput == "Add") {
                    Console.WriteLine("What is the make of the car?");
                    String make = Console.ReadLine();
                    Console.WriteLine("What is the model of the car?");
                    String model = Console.ReadLine();
                    Console.WriteLine("What is the color of the car?");
                    String color = Console.ReadLine();

                    Car car = new Car(color,make,model);
                    Console.WriteLine("What slot do you want to park the car in?");
                    string slotString = Console.ReadLine();
                                    }
            }
        }
    }

    //want to represent car as class.
    //represent garage as a class.
    // we want to use our parking garage class to manage our inventory.

    public class Car
    {
        public String make {get; private set;}
        public String model{ get; private set;}
        public String color;
        public String plateNumber;
        public int year;

        public Car(string initialColor, String initialMake, String intialModel){
            this.color = initialColor;
            this.make = initialMake;
            this.model = intialModel;
        }

        public String ToString(){
            String stringRepresentation = string.Format("{0} {1} {2}", this.color, this.make, this.model);

            return stringRepresentation;
        }
    }

    public class ParkingGarage
    {
        public int numSpaces {get; private set;}
        private Car[] parkingSlots;


        public ParkingGarage(int desiredNumberOfSlots)
        {
            parkingSlots = new Car[desiredNumberOfSlots];
            numSpaces = desiredNumberOfSlots;
        } 

        public bool isSlotAvailable(int slotNumber)
        {
            Car theCarInTheSlot = parkingSlots[slotNumber];
            if(parkingSlots[slotNumber] == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        
        
        }

        public void ParkCar(Car theCar, int theSlot)
        {
            bool isSlotEmpty = isSlotAvailable(theSlot);
            //bad parking garage
            if(isSlotEmpty == true){
            this.parkingSlots[theSlot] = theCar;
        } else{
            throw new Exception("Slot "+theSlot+ " is taken!");
        }

        }

        public Car towCar(int theSlot)
        {
            Car c = parkingSlots[theSlot];
            parkingSlots[theSlot] = null;
            
            return c;
        }
    }
}
