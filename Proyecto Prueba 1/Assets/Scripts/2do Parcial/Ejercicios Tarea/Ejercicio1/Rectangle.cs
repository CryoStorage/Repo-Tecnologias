using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour 
{
	// Atributes
	
	private Vector2 point1;
	private Vector2 point2;
	
	//private float [] val;
	
	private float getBase(Vector3 a, Vector3 b)
	{
		if (a.x < 0 && b.x < 0)
		{
			return((a.x *-1) - (b.x * -1));
 
		}
		
		if (a.x < 0)
		{
			float neg = a.x*-1;
			return neg + b.x;
			
		}
		
		if (b.x < 0)
		{
			float neg = b.x*-1;
			return a.x + neg;
		}
		
		return a.x - b.x;

	}
	
	private float getHeight(Vector2 a, Vector2 b)
	{
		if (a.y < 0 && b.y < 0)
		{
			return((a.y *-1) + (b.y * -1));
 
		}
		
		if (a.y < 0)
		{
			return a.y + b.y;
			
		}
		
		if (b.y < 0)
		{
			return a.y + b.y;
		}
		
		return a.y + b.y;
		
	}
	
	private float getPerimeter(Vector2 a, Vector2 b)
	{
		if (a.x < 0 && a.y < 0 && b.x < 0 && b.y < 0)
		{
			float aX = a.x * -1;
			float aY = a.y * -1;
			float bX = b.x * -1;
			float bY = b.y * -1;
			return (aX + bX + aY + bY);
		}else
		{
			return(0);
		}
		
		
		
		
		
		
		
		
		
		
	}

	
	/*
	private float getArea()
	{
		
		
	}*/
	
	void Start()
	{
		point1 = new Vector2 (-1.4f, -3f);
		point2 = new Vector2 (-3.3f, -5f);
		
		Debug.Log("Base is: " + getBase(point1,point2));
		Debug.Log("Height is" + getHeight(point1,point2));
		
		
	}
	

	
	
}
