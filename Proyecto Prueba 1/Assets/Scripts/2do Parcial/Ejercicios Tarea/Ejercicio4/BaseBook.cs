using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseBook 
{
	// Atributes
	private string title;
	
	private string author;
	
	private int pages;

	// Constructors 
	public BaseBook(string aTitle, string aAuthor, int aPages)
	{
		aTitle = title;
		aAuthor = author;
		aPages = pages;
		
	}
	
	public BaseBook()
	{
		
	}
	
	// Getters Setters Properties
	public string Title
	{
		get {return title;}
		set 
		{
			if (value != null)
			{
				title = value;	
				
			}else
			{
				Title = "N/A";
			}
		}
	
	}
	
	public string Author
	{
		get {return author;}
		set 
		{
			if (value != null)
			{
				author = value;	
				
			}else
			{
				author = "N/A";
			}
		}
	}
	
	public int Pages
	{
		get {return pages ;}
		set 
		{
				pages = value;	

		}
	}
}
