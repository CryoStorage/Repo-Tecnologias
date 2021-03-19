using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
	
	[SerializeField] private float newHour;
	[SerializeField] private float newMinute;
	[SerializeField] private float newSecond;
	
	CustomTime customTime;
	
	void Start()
	{
		customTime = new CustomTime(0f,0f,0f);
		
	}
	public void StartTime()
	{
		StartCoroutine(getTime());
		
	}
	
	public void SetTime()
	{
		customTime.Hour = newHour;
		customTime.Minute = newMinute;
		customTime.Second = newSecond;
		
	}
	
	IEnumerator getTime()
	{
		while (true)
			{
				yield return new WaitForSeconds(1);
				customTime.Second ++;
			Debug.Log( customTime.Hour+ "h " +customTime.Minute + "m " + customTime.Second + "s ");
				CheckTime();
			}
		
	}
	
	void CheckTime()
	{
		if (customTime.Second >= 60f)
		{
			AddMinute();
		}
		
		if (customTime.Minute >= 60f)
		{
			AddHour();
		}
		
	}
	
	void AddMinute()
	{
		customTime.Second = 0;
		customTime.Minute ++;
		
	}
	
	void AddHour()
	{
		customTime.Minute = 0;
		customTime.Hour ++;
		
	}
	
	
	
}
