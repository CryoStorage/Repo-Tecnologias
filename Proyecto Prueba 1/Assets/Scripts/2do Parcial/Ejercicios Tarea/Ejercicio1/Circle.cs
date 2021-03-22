using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
	// Atributes
	private Vector2 center;
	private float radius;
	
	// Constructors
	public Circle(Vector2 aCenter, float aRadius)
	{
		aCenter = center;
		aRadius = radius;
		
	}
	
	public Circle()
	{
		
		
	}
	
	// Getters Setters Properties
	public Vector2 Center
	{
		get{return center;}
		set
		{
			center = value;
			
		}
	}
	
	public float Radius
	{
		get{return radius;}
		set
		{
			radius = value;
			
		}
	}
}
