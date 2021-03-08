using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalculationTest : MonoBehaviour
{
	private Calculation calculation;
	
	[SerializeField]
	int val1;
	[SerializeField]
	int val2;
	
    // Start is called before the first frame update
    void Start()
    {
	    Calculation.Add(val1, val2);
	    Calculation.Subtract(val1, val2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
