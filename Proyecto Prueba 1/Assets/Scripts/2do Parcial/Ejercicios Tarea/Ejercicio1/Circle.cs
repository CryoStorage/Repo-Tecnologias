using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
	// Atributes
	private Vector2 center;
	private float radius;
	private float diameter;
	private float perimeter;
	
	// Constructors
	public Circle(Vector2 aCenter, float aRadius)
	{
		Center= aCenter;
		Radius = aRadius;
		
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
	
	public float Diameter
	{
		get {return diameter;}
		set {Diameter = value;}
	}
	
	public float Perimeter
	{
		get {return perimeter;}
		set {perimeter = value;}
	}
	
	
	// Functions
	public float getRadius(Circle circ)
	{
		float rad;
		rad = circ.Radius;
		return rad;
		
	}
	
	public float getDiameter(Circle circ)
	{
		float diam;
		diam = circ.Radius * 2;
		return circ.Diameter = diam;
		
	}
	
	public float getPerimeter(Circle circ)
	{
		float perim;
		perim = ((Mathf.PI) * (circ.Radius *2));
		return circ.Perimeter = perim;
	}
	
	
}
