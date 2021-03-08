using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptA : MonoBehaviour
{
	public string name;
	
	public void Function1(string name)
	{
		Debug.Log(name);

	}
	
	public string Function2(string name)
	{
		return name + "ha llamado mi Funcion1, soy scriptA";
		
	}
}
