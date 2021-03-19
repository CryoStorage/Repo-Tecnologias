using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Circle
{
	private float speed;
	
	private string weapon;
	
	private float hp;
	
	public Enemy(float aSpeed, string aWeapon, float aHp)
	{
		speed = aSpeed;
		weapon = aWeapon;
		hp = aHp;
		
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
	
	public string Weapon
	{
		get 
		{
			return weapon;
		}
		
		set 
		{
		 weapon	= value;
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
}
