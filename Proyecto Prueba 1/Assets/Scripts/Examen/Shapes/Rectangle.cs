using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle
{
	// Attributes
	[HideInInspector]
	public int sides = 4;
	public float length1;
	public float length2;
	
	// Constructors
	public Rectangle(int aLenght1, int aLenght2)
	{
		length1 = aLenght1;
		length2 = aLenght2;
		
	}
	
	public Rectangle()
	{
		
		
	}
}
