using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangle : MonoBehaviour 
{
	// Atributes
	private float aX;
	private float aY;
	private float bX;
	private float bY;
	
	private Vector2 a;
	private Vector2 b;
	
	private float height;
	private float width;
	private float area;
	private float perimeter;

	

	
	private List<float> values = new List<float>();

	private float getWidth(Vector2 a, Vector2 b)
	{
		float lenght;

		lenght = ((a.x - b.x) * -1);
		return lenght;

	}
	
	private float getHeight(Vector2 a, Vector2 b)
	{
		float width;
		
		width = ((a.y - b.y) * -1); 
		return width;
		
	}
	
	private float getPerimeter(Vector2 a, Vector2 b)
	{
		float perimeter = width + height + width + height;
		return perimeter;
		
		
	}
	
	private float getArea(Vector2 A, Vector2 B)
	{
		float area = (height * width);
		return area;
		
	}
	
	void Awake()
	{
		values.Add (aX = 0f);
		values.Add (aY = 0f);
		values.Add (bX = 0f);
		values.Add (bY = 0f);
		
		
		
	}
	
	void Start()
	{
		a = new Vector2 (aX, aY);
		b = new Vector2 (bX, bY);
		
	}
	
	public void MakeRectangle()
	{
		Randomize();
		UpdateValues();	
		
	}
	
	void Randomize()
	{
		for (int i = 0; i < values.Count; i++) 
		{
			values[i] = Random.Range(-5f , 5f);
		}

			
	}
	
	void UpdateValues()
	{
		a = new Vector2(values[0], values[1]);
		b = new Vector2(values[2], values[3]);
		
		height = getHeight(a,b);
		width = getWidth(a,b);
		area = getArea(a,b);
		perimeter = getPerimeter(a,b);
		
	}
	
	public void ShowValues()
	{
		
		Debug.Log("Coordinates are:"+"aX = "+values[0]+"aY = "+values[1]+"bX = "+values[2]+"bY = "+values[3]);
	
		
		Debug.Log("Rectangle Height is: " + height);
		Debug.Log("Rectangle Base is: " + width);
		Debug.Log("Rectangle Area is: " + area);
		Debug.Log("Rectangle Perimeter is; " + perimeter);
				
	}
	

	
}
