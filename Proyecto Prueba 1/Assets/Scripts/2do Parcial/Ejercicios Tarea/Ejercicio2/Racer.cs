using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racer : Vehicle
{
	// Atributes
	
	private int doors;
	private int passengers;
	private float cylinders;
	private float gasCapacity;
	private float topSpeed;
	private int gears;
	private string name;
	
	
	// Constructors
	
	public Racer(int aDoors, int aPassengers, float aCylinders, float aGasCapacity, float aTopSpeed, int aGears, string aName)
	{
		aDoors = doors;
		aPassengers = passengers;
		aCylinders = cylinders;
		aGasCapacity = gasCapacity;
		aTopSpeed = topSpeed;
		aGears = gears;
		aName = name;
	}
	
	public Racer(float aTopSpeed, string aName)
	{
		aTopSpeed = topSpeed;
		aName = name;
		
	}
	
	
	// Getters Setters Properties
	
	public int Doors
	{
		get {return doors;}
		set
		{
			doors = value;
		}
	}
	
	public int Passengers
	{
		get {return passengers;}
		set
		{
			passengers = value;
		}
	}
	
	public float Cylinders
	{
		get {return cylinders;}
		set
		{
			cylinders = value;
		}
	}
	
	public float GasCapacity
	{
		get {return gasCapacity;}
		set
		{
			gasCapacity = value;
		}
	}
	
	public float TopSpeed
	{
		get {return topSpeed;}
		set
		{
			topSpeed = value;
		}
	}
	
	public int Gears
	{
		get {return gears;}
		set
		{
			gears = value;
		}
	}
	
	public string Name
	{
		get {return name;}
		set
		{
			name = value;
		}
	}
	
	
	


  
}
