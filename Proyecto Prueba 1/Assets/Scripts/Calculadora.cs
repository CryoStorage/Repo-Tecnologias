using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculadora : MonoBehaviour
{
	public float Valor1;
	
	public char Operacion;
	
	public float Valor2;
	
	
	
	[HideInInspector]
	public float Resultado;
	
	
    // Start is called before the first frame update
    void Start()
    {
	    Operar();
    }
    
	void Operar()
	{
		Debug.Log(Resultado);
	}
	
	public string [] Operaciones;

    // Update is called once per frame
	public void Sumar()
    {
	    Resultado = Valor1 + Valor2;
    }
    
	public void Restar()
	{
		Resultado = Valor1 - Valor2;
		
	}
	
	public void Multiplicar()
	{
		Resultado = Valor1 * Valor2;		
	}
	
	public void Dividir()
	{
		Resultado = Valor1 / Valor2;
	}
    
    
}
