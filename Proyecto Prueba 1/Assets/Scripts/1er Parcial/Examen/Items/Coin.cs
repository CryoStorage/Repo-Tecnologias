using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : Circle
{
	private float worth;
	
	private string color;
	
	private float weight;
	
	public Coin(float aWorth, string aColor, float aWeight)
	{
		worth = aWorth;
		color = aColor;
		weight = aWeight;
		
	}
	
	// Getters Setters Properties
	public float Worth
	{
		get 
		{
			return worth;
		}
		
		set 
		{
		
			Worth = value;
		}
	}
	
	public string Color
	{
		get 
		{
			return color;
		}
		
		set 
		{
		 color	= value;
		}
	}	
	
	public float Weight
	{
		get 
		{
			return weight;
		}
		
		set 
		{
			weight	= value;
		}
	}
}
