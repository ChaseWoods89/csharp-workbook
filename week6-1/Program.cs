using System;

namespace week6_1
{
    class Program
    {
        static void Main(string[] args)
        {
             Human h1 = new Human("Peter Parker","Spiderman");
             SuperHuman s1 = new SuperHuman("Spider-man", "Peter Parker", "Whatever a spider can do");
             Human s2 = new SuperHuman("Star Lord" , "Peter Quill", "I'm Star Lord, man.");
             
             
             Console.WriteLine(s1.GetGreeting());
             greetBack(s1);
             Console.WriteLine(s2.GetGreeting());
             greetBack(s2);
             
        }
        public static void greetBack( Human Human){
            Console.WriteLine("Hi {0}, nice to meet you!", Human.name);
        }
    }
    public class Human {
        public string name {get; private set;}
        public string nickname;

        public Human(string initialName, string initialNickname){
            this.name = initialName;
            this.nickname = initialNickname;
        }
        virtual
        public String GetGreeting(){
            string greeting = 
                string.Format("Hi my name is " + this.name + ", but you can call me " + this.nickname);
            return greeting;        
            }
    }
     
    public class SuperHuman : Human {
        public string superPower{get; private set;}
        private string realName;

        public SuperHuman(string initialName, string initialRealName, string intialSuperPower):
        base(initialName, null){
            this.realName = initialRealName;
            this.superPower = intialSuperPower;
        }
        override
        public string GetGreeting(){
            string greeting = 
                string.Format( "They call me " + this.name +  " and my superpower is " + this.superPower);
            return greeting;
        }
    
    }
}

