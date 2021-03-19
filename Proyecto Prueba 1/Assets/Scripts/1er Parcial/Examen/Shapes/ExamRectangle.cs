using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamRectangle
{
	// Attributes
	[HideInInspector]
	public int sides = 4;
	public float length1;
	public float length2;
	
	// Constructors
	public ExamRectangle(int aLenght1, int aLenght2)
	{
		length1 = aLenght1;
		length2 = aLenght2;
		
	}
	
	public ExamRectangle()
	{
		
		
	}
}
