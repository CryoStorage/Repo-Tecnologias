using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculation : MonoBehaviour
{
	//primer valor que se va a sumar o restar al valor2
	public int val1;
	
	//segundo valor que se va a sumar o restar al valor 1
	public int val2;
	
	//resultado de la operaciion
	public static int res;
	
	void Start()
	{
		Add(val1, val2);
		Subtract(val1, val2);
		
	}
	
	
	public static void Add(int val1, int val2)
	{
		res = val1 + val2;
		Debug.Log("res of Add is : " + res);
		
	}
	
	public static void Subtract(int val1, int val2)
	{
		res = val1 - val2;
		Debug.Log("res of Subtract is : " + res);
	}
	
	
}
