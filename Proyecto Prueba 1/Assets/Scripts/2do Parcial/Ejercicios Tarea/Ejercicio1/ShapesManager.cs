using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesManager : MonoBehaviour
{
	
	private Circle circle;
	
	private Vector2 center;
	private float aX = 0;
	private float aY = 0;
	private float radius = 0;
	
	private float getRadius(Circle circ)
	{
		float rad;
		rad = circ.Radius;
		return rad;
		
	}
	
	private float getDiameter(Circle circ)
	{
		float diam;
		diam = circ.Radius * 2;
		return diam;
		
	}
	private float getPerimeter(Circle circ)
	{
		float perim;
		perim = ((Mathf.PI) * (circ.Radius *2));
		return perim;
	}
	
	
    // Start is called before the first frame update
    void Start()
	{
		center = new Vector2(aX, aY);
	    circle = new Circle(center, radius);

    }


	public void Randomize()
	{
		aX = Random.Range(-5f, 5f);
		aY = Random.Range(-5f, 5f);
		radius = Random.Range(-5f, 5f);
		
		UpdateValues();
	}
	
	void UpdateValues()
	{
		circle = new Circle(center, radius);
		center = new Vector2(aX, aY);
		
		
	}
	
	public void ShowValues()
	{
		Debug.Log(" Center: "+center+" Radius: "+radius);
		
		Debug.Log("Radius is: " + getRadius(circle));
		Debug.Log("Diameter is: "+ getDiameter(circle));
		Debug.Log("Perimeter is: "+ getPerimeter(circle));
		
	}
	

}
