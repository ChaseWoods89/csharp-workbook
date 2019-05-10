using System;
using System.Collections.Generic;

namespace week6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Supra = new Car("Supra", 101);
            Car Mustang = new Car("Mustang", 96 );
            Car Accord = new Car("Accord", 76);
            Car VWBug = new Car("VW Bug", 71);
            Person Flash = new Person("Flash", 100000);
            Person Usain = new Person("Usain Bolt", 150);

            List<IRace> racers = new List<IRace>();

            racers.Add(Supra);
            racers.Add(Mustang);
            racers.Add(Accord);
            racers.Add(VWBug);
            racers.Add(Flash);
            racers.Add(Usain);

            foreach(IRace r1 in racers){
                foreach(IRace r2 in racers){
                    IRace winner = Race(r1, r2);
                    Console.WriteLine("{0} VS. {1} = {2}", r1, r2, winner.getCelebrateMessage() );
                }

            }


        
        }

        public static IRace Race(IRace r1, IRace r2)
        {   
          if(r1.getSpeedMPH() < r2.getSpeedMPH()){
              return r2;
          }
          else{
              return r1;
          }
        }
    }
        public interface IRace
        {
            double getSpeedMPH();
            string getCelebrateMessage();
        }

    public class Car : IRace 
    {
        public string name;
        public double speedMPH;

        public Car(string initialName, double initialAverageSpeed)
        {
            this.name = initialName;
            this.speedMPH = initialAverageSpeed;

        }
        public string getCelebrateMessage(){
            return "Vroom! Vroom!"; 
        }

        public double getSpeedMPH(){
            return this.speedMPH;
        }
    override
    public String ToString(){
        string s = string.Format("{0} ({1})", this.name, this.speedMPH);
        return s;
    }
    }

    public class Person : IRace
    {
        string name;
        double speedMPM;
    public Person(string initialName, double initialAverageSpeedMeters ){
        this.name = initialName;
        this.speedMPM = initialAverageSpeedMeters;
    }
    public string getCelebrateMessage(){
            return "Man wins!"; 
    }
    public double getSpeedMPH(){
        return speedMPM * 60 / 1609.34;
    }
    override
    public String ToString(){
        //string s = string.Format("{0} ({1})", this.name, this.speedMPM);
        return this.name;
    }
    }


}
