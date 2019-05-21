﻿using System;
					
public class Program
{
	public static void Main()
	{
		Person chase = new Person("Chase");
		Car blueCar = new Car("blue", chase);
		Garage smallGarage = new Garage(2);
		
		smallGarage.ParkCar(blueCar, 0);
		Console.WriteLine(smallGarage.Cars);
	}
}

public class Person
{
    public string name;

	public Person(string initialName)
	{
		this.name = initialName;
	}
}

class Car
{
    public Car(string initialColor, Person initialPerson)
    {
    	Color = initialColor;
		this.person = initialPerson;
		
    }
    
    public string Color { get; private set; }
	public Person person;
}


class Garage
{
    private Car[] cars;
    
    public Garage(int initialSize)
    {
    	Size = initialSize;
	    this.cars = new Car[initialSize];
    }
    
    public int Size { get; private set; }
    
    public void ParkCar (Car car, int spot)
    {
        cars[spot] = car;
    }
    
    public string Cars {
		get {
			for (int i = 0; i < cars.Length; i++)
			{
				if (cars[i] != null) {
					Console.WriteLine(String.Format("The {0} car with {1} in it is in spot {2}.", cars[i].Color, cars[i].person.name, i));
				}
			}
			return "That's all!";
		}
	}
}