using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : BaseBook
{
	// Atributes
	private int year;
	private string genre;
	private string condition;
	private string color;
	
	// Constructors
	public Book(int aYear, string aGenre, string aCondition, string aColor)
	{
		aYear = year;
		aGenre = genre;
		aCondition = condition;
		aColor = color;
		
	}
	
	public Book(string aTitle, string aAuthor, int aPages, int aYear, string aGenre, string aCondition, string aColor)
	{
		aTitle = Title;
		aAuthor = Author;
		aPages = Pages;
		aYear = year;
		aGenre = genre;
		aCondition = condition;
		aColor = color;
		
	}
	
	// Getters Setters Properties
	
	public int Year
	{
		get {return year;}
		set
		{
				year = value;	

		}
	}
	
	public string Genre
	{
		get {return genre;}
		set 
		{
			if (value != null)
			{
				genre = value;	
				
			}else
			{
				genre = "N/A";
			}
		}
	}
	
	public string Condition
	{
		get {return condition;}
		set 
		{
			if (value == "new" || value == "used")
			{
				condition = value;	
				
			}else
			{
				condition = "N/A";
			}
		}
	}
	
	public string Color
	{
		get {return color ;}
		set 
		{
			if (value != null)
			{
				color = value;	
				
			}else
			{
				color = "N/A";
			}
		}
	}
}
