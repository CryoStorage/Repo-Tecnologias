using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle 
{
	// Atributes
	private float height;
	private float weight;
	private string color;
	private float surface;
	
	
	// Constructors
	
	public Vehicle()
	{
		
		
	}
	public Vehicle(float aWeight)
	{
		aWeight = weight;
		
	}
	
	public Vehicle(float aSurface, float aWeight)
	{
		aSurface = surface;
		aWeight = weight;
		
	}
	
	public Vehicle(float aHeight, float aWeight, string aColor, float aSurface)
	{
		aHeight = height;
		aWeight = weight;
		aColor = Color;
		aSurface = surface;
		
	}
	
	
	// Getters Setters Properties
	
	public float Height
	{
		get{return height;}
		set{ height = value;}
	}
	
	public float Weight
	{
		get{return weight;}
		set{weight = value;}
	}
	
	public string Color
	{
		get{return Color;}
		set 
		{
			if (value == "Red" || value == "Blue")
			{
				Color = value;
			}
		}
	}
	
	public float Surface
	{
		get{return surface;}
		set {surface = value;}
	}
	
	
	
}
