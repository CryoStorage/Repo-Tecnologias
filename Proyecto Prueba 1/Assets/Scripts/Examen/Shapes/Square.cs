using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square
{
	// Attributes
	[HideInInspector]
	public int sides = 4;
	public float length;
	
	// Constructors
	public Square(float aLength)
	{
		length = aLength;
		
	}
	
	public Square()
	{
		
		
	}
}
