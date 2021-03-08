using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceGame : MonoBehaviour
{
	int dice1;
	int dice2;
	int dice3;
    // Start is called before the first frame update
    void Start()
    {
	    Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
	public void CheckResult()
	{
		if ((dice1 == dice2) && (dice3 == dice2))
		{
			Debug.Log("You Win!");
			
		}else
		{
		Debug.Log("You Lose!");
		}
		
	
		
	}
    
	public void RollDice()
	{
		dice1 = Random.Range(1,7);
		Debug.Log("dice1 is " + dice1);
		dice2 = Random.Range(1,7);
		Debug.Log("dice2 is " + dice2);
		dice3 = Random.Range(1,7);
		Debug.Log("dice3 is " + dice3);
		
		CheckResult();
		
	}
}
