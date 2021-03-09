using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Circle
{
	// Atributes
	private float speed;
	
	private float damage;
	
	private float power;
	
	// Constructors
	public Bullet(float aSpeed, float aDamage, float aPower)
	{
		speed = aSpeed;
		damage = aDamage;
		power = aPower;
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
			value = speed;
		}
	}
	
	public float Damage
	{
		get 
		{
			return damage;
		}
		
		set 
		{
			value = damage;
		}
	}	
	
	public float Power
	{
		get 
		{
			return power;
		}
		
		set 
		{
			value =  power;
		}
	}
}
