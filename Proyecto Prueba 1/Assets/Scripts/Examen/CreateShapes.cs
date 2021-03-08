using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShapes : MonoBehaviour
{
	[SerializeField]
	private int toCreate;
	
	
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	//creates three of each shape type
	public void Create()
	{
		Circle circle1 = new Circle(32);
		Circle circle2 = new Circle(55.3f);
		Circle circle3 = new Circle(9);
		
		Square square1 = new Square(5);
		Square square2 = new Square(8);
		Square square3 = new Square(3.5f);
		
		Triangle triangle1 = new Triangle();
		Triangle triangle2 = new Triangle();
		Triangle triangle3 = new Triangle();
		
		Rectangle rectangle1 = new Rectangle();
		Rectangle rectangle2 = new Rectangle();
		Rectangle rectangle3 = new Rectangle();
		
	}
}
