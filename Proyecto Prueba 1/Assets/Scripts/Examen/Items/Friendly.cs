using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friendly : Circle
{
  
	private float speed;
	
	private float hp;
	
	private float friendlyness;
	
	public Friendly(float aSpeed, float aHp, float aFriendlyness)
	{
		speed = aSpeed;
		hp = aHp;
		friendlyness = aFriendlyness;
		
	}
	
	// Getters Setters Properties
	public float Speed
	{
		get 
		{
			return speed;
		}
		
		set 
		{
		
			speed = value;
		}
	}
	
	public float Hp
	{
		get 
		{
			return hp;
		}
		
		set 
		{
		 hp	= value;
		}
	}	
	
	public float Friendlyness
	{
		get 
		{
			return friendlyness;
		}
		
		set 
		{
			friendlyness = value;
		}
	}
}
