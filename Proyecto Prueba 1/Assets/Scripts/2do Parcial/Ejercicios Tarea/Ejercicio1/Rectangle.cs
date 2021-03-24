using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle
{
	// Attributes
	
	Vector2 a;
	Vector2 b;
	
	float height;
	float width;
	float area;
	float perimeter;
	float length;
	
	// Constructors
	public Rectangle(Vector2 aA, Vector2 aB)
	{
		A = aA;
		B = aB;
		
	}
	
	// Getters Setters Properties
	public Vector2 A
	{
		get {return a;}
		set {a = value;}
	}
	
	public Vector2 B
	{
		get{return b;}
		set{a = value;}
	}
	
	public float Height
	{
		get{return height;}
		set{height = value;}
	}
	
	public float Width
	{
		get{return width;}
		set{width = value;}
	}
	
	public float Area
	{
		get{return area;}
		set{area = value;}
	}
	
	public float Perimeter
	{
		get{return perimeter;}
		set{perimeter = value;}
	}
	
	public float Length
	{
		get{return length;}
		set{length = value;}
	}
	
	// Functions
	public float getWidth(Rectangle rect)
	{
		float width = rect.A.y - rect.B.y;
		return rect.Width = width;
	
	}
	
	public float getHeight(Rectangle rect)
	{
		float height = rect.A.x - rect.B.x;
		return rect.Height = height;
		
	}
	
	public float getArea(Rectangle rect)
	{
		float area = getHeight(rect) * getWidth(rect);
		return rect.Area = area;
	}
	
	public float getPerimeter(Rectangle rect)
	{
		float perimeter = (getHeight(rect) *2) + (getHeight(rect) * 2);
		return rect.Perimeter = perimeter;
		
	}
}
