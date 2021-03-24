using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapesManager : MonoBehaviour
{

	Vector2 a;
	Vector2 b;
	Vector2 c;
	
	private float aX;
	private float aY;
	private float bX;
	private float bY;
	private float cX;
	private float cY;
	
	private float rad;
	private Rectangle rect;
	private Circle circ;
	private Triangle trig;
	
	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start()
	{
		Randomize();
		ShowValues();
	}
	
	public void Randomize()
	{
		aX = Random.Range(-5,5);
		aY = Random.Range(-5,5);
		bX = Random.Range(-5,5);
		bX = Random.Range(-5,5);
		a = new Vector2(aX, aY);
		b = new	Vector2(bX, bY);
		Rectangle rect = new Rectangle(a,b);
		Circle circ =  new Circle(a, rad);
		Triangle trig = new	Triangle(a,b,c);
		
		
	}
	
	public void ShowValues()
	{
		Debug.Log( "Vector a: "+a+" Vector B: "+b);
		//	Debug.Log(" Rectangle Height is: "+ rect.getHeight(rect)+" Rectangle width is: "+ rect.getWidth(rect)+
		//	" Rectangle Perimeter is: "+rect.getPerimeter(rect)+" Rectangle Area is: "+rect.getArea(rect));
		
		//Debug.Log(" Triangle type is: "+trig.getTriangle(trig));
		
		//Debug.Log(" Circle radius is: "+circ.Radius+" Circle diameter is: "+circ.getDiameter(circ)+
		//	" Circle perimeter is; "+circ.getPerimeter(circ));

	}
	
}
