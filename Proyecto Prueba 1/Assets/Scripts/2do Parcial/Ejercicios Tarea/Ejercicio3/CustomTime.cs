using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomTime
{
	// Atributes
	
	private float hour;
	private float minute;
	private	float second;
	
	// Constructors
	public CustomTime(float aHour, float aMinute, float aSecond)
	{
		aHour = hour;
		aMinute = minute;
		aSecond = second;
		
	}
	
	
	// Getters Setters Properties
	
	public float Hour
	{
		get {return hour;}
		set 
		{
			hour = value;
		}
	}
	
	public float Minute
	{
		get {return minute;}
		set 
		{
			minute = value;
		}
	}
	
	public float Second
	{
		get {return second;}
		set 
		{
			second = value;
		}
	}
}
