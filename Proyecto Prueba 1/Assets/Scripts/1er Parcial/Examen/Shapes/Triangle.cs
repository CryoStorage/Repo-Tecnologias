using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle
{
	// Attributes
	[HideInInspector]
	public int sides = 3;
	public float length1;
	public float length2;
	public float length3;
	
	// Constructors
	public Triangle( float aLenght1, float aLenght2, float aLenght3 )
	{
		length1 = aLenght1;
		length2 = aLenght2;
		length3 = aLenght3;
	}
	
	public Triangle()
	{
		
		
	}
	
}
