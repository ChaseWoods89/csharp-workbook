using System;
using System.Collections.Generic;

namespace Rentable
{
    class Program
    {
        static void Main(string[] args)
        {
            Boat b1 = new Boat(59, "John Boat");
            Boat b2 = new Boat(129, "Speed Boat");
            Boat b3 = new Boat(400, "Yacht");

            House h1 = new House(700, "Victorian");
            House h2 = new House(350, "Shanty");
            House h3 = new House(1400, "Penthouse Suite");

            Car c1 = new Car(140, "Corvette");
            Car c2 = new Car (89, "Ford F-150");
            Car c3 = new Car(41, "KIA Soul");

            List<IRentable> rentals = new List<IRentable>();

            rentals.Add(b1);
            rentals.Add(b2);
            rentals.Add(b3);
            rentals.Add(h1);
            rentals.Add(h2);
            rentals.Add(h3);
            rentals.Add(c1);
            rentals.Add(c2);
            rentals.Add(c3);

            foreach(var rental in rentals){
                Console.WriteLine(rental.getDescription());
                
            }
 
            
        }
    }

    public interface IRentable{
       int getDailyRate();        
       string getDescription();
    }

    public class Boat : IRentable
    {
        int hourlyRate;
        string boatType;

        public Boat(int initialHourlyRate, string intialBoatType){
            this.hourlyRate = initialHourlyRate;
            this.boatType = intialBoatType;
        }

        public int getDailyRate(){
           return this.hourlyRate * 24;
        }
        public string getDescription(){
            string s1 = string.Format("This is a " + this.boatType + " it costs " +getDailyRate() + " per day.");
            return s1;
        }
    }

    public class Car : IRentable
    {
        int dailyRate;
        string carType;

        public Car(int initialDailyRate, string intialCarType){
            this.dailyRate = initialDailyRate;
            this.carType = intialCarType;
        }

       public int getDailyRate(){
            return this.dailyRate;
        }
       public string getDescription(){
           string s2 = string.Format("This is an awesome " + this.carType + " and it costs " + this.dailyRate + " per day.");
           return s2;
        }
    }
    public class House : IRentable
    {
        int weeklyRate;
        string houseType;

        public House(int initialWeeklyRate, string initialHouseType){
            this.weeklyRate = initialWeeklyRate;
            this.houseType = initialHouseType;
        }
        public  int getDailyRate(){
            return (this.weeklyRate / 7); 

        }
        public string getDescription(){
            string s3 = string.Format("This is a " + this.houseType + " style house and costs " + getDailyRate() + " per day." );
            return s3;
        }

    }
}
