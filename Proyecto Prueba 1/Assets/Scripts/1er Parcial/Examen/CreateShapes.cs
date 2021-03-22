using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShapes : MonoBehaviour
{
	[SerializeField]
	private int toCreate;
	
	ExamCircle circle1;
	
	Square square1;
	
	Triangle triangle1;
	
	ExamRectangle rectangle1;

    
	//creates one of each shape type
	public void Create()
	{
		circle1 = new ExamCircle(Random.Range(1f,5f));

		
		square1 = new Square(Random.Range(1f,5f));

		
		triangle1 = new Triangle(2f,4f,12f);
		

		rectangle1 = new ExamRectangle(Random.Range(1,5), Random.Range(1,5));
		
		DebugFigures();

		
	}
	
	//debugs the properties of each shape created
	public void DebugFigures()
	{
		Debug.Log("Shape type is: " + circle1 + ", Radius is: " + circle1.radius);
		
		Debug.Log("Shape type is: " + square1 + ", Side Lenght is: " + square1.length);
		
		Debug.Log("Shape type is: " + triangle1 + ", Side1 Lenght is: " + triangle1.length1 + 
			", side2 Lenght is: " + triangle1.length2 + ", side3 Lenght is: " + triangle1.length3);
			
		Debug.Log("Shape type is: " + rectangle1 + ", Side1 Lenght is: " + rectangle1.length1 +
			", Side2 Lenght is: " + rectangle1.length2);
		
	}
}
