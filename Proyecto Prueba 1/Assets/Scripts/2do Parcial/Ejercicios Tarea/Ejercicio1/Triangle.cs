using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle 
{
	// Atributes
	private Vector2 a;
	private Vector2 b;
	private Vector2 c;


	
	private float getSide(Vector2 a, Vector2 b)
	{
		float ab = a.x - b.x;
		return(ab);
	}
	
	// Constructors 
	public Triangle(Vector2 aA, Vector2 aB, Vector2 aC)
	{
		aA = a;
		aB = b;
		aC = c;
		
	}
	public Triangle()
	{
		
	}
	
	
	// Getters Setters Propperties
	
	public Vector2 A
	{
		get{return a;}
		set{a = value;}
	}
	
	public Vector2 B
	{
		get{return b;}
		set{b = value;}
	}
	public Vector2 C
	{
		get{return c;}
		set{c = value;}
	}
	
	// Functions
	public string getTriangle(Triangle trig)
	{
		string ans;
		if (Vector2.Distance(A,B) == Vector2.Distance(B,C) || Vector2.Distance(A,C) == Vector2.Distance(B,C))
		{
			return ans = "Equilateral";
		}
		
		if (Vector2.Distance(A,B) == Vector2.Distance(B,C))
		{
			return ans = "Isoceles";
		}
		else
		{
			return ans = "Scalene";
		}
		
	}
	
	private float getPerimeter(Triangle trig)
	{
		float perim = Vector2.Distance(A,B) + Vector2.Distance(B,C) + Vector2.Distance(C,A);
		return perim;
		
	}
	
	private float getArea(Triangle trig)
	{
		float tBase;
		float tHeight;
		float ans;
		if (Vector2.Distance(trig.A , trig.B) > Vector2.Distance(trig.B, trig.C) || 
			Vector2.Distance(trig.A , trig.B) < Vector2.Distance(trig.B, trig.C))
		{
			tBase = trig.A.x - trig.b.x;
			tHeight = trig.A.x - c.x;
		}
		else
		{
			tBase = trig.C.x - trig.A.x;
			tHeight = trig.B.x - C.x;
		}
		
		return ans = (tBase / 2) * tHeight;
		

		
	}
}
