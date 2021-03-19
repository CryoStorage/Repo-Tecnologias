using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Library : MonoBehaviour
{
	
	[SerializeField] private static int capacity = 4;
	public Book[] books = new Book[capacity];
	private int currentBooks = 0;
	[SerializeField] private int toReplace;
	
	// Parameters of book to be created
	[SerializeField]string newTitle;
	[SerializeField]string newAuthor;
	[SerializeField]int newPages;
	[SerializeField]int newYear;
	[SerializeField]string newGenre;
	[SerializeField]string newCondition;
	[SerializeField]string newColor;
	
	
	Book book0 = new Book ("book1", "pepe", 200, 1999, "fiction", "used", "green");
	
	void Start()
	{
		books[0] = book0;
		
		CheckCapacity();
		Debug.Log("Capacity is: " + capacity );
		
	}
	
	void ModifyArray(Book temp, int id)
	{
		
		if (currentBooks >= capacity)
		{
			ReplaceBook(temp, toReplace);
			CheckCapacity();
		}else
		{
			AddBook(temp, currentBooks);
			CheckCapacity();
		}
	}
	
	void ModifyArray(Book temp)
	{
		AddBook(temp, currentBooks);
		CheckCapacity();

	}
	
	public void ShowBooks()
	{/*
		for (int i = 0; i < currentBooks; i++) 
		{
			if (books[i] != null)
			{
				Debug.Log("Book" + i + " is: " + books[i].Title + " By: " +  books[i].Author + ", " +books[i].Pages + 
					" Pages Long, " + "published in: " + books[i].year + "Genre: " + books[i].genre + " Condition: " + 
					books[i].condition + "Color: " + books[i].color);
			}else
			{
				Debug.Log("Array Ends");
				return;
			}
			
		}*/
		
		if (books[0].Title != null)
		{
			Debug.Log(books[0].Title.ToString());
		}else
		{
			Debug.Log("isnull");
		}
	
		Debug.Log(books[0].Author);
		Debug.Log(books[0].Pages);
		Debug.Log(books[0].Year);
		Debug.Log(books[0].Genre);
		Debug.Log(books[0].Condition);
		Debug.Log(books[0].Color);


	}
    
	void AddBook(Book toAdd, int id)
	{
		books[id] = toAdd;
		
	}
	
	void CheckCapacity()
	{
		foreach ( Book book in books)
		{
			if (book is Book)
			{
				currentBooks ++;
				Debug.Log("Current Books: " + currentBooks);
			}
		}
	}
	

	
	public void CreateBook(string title, string author, int pages, int year, string genre, string condition, string color)
	{
		Book temp = new Book (title,author,pages, year, genre, condition, color);
		ModifyArray(temp);
		
	}
	
	
	void ReplaceBook(Book temp, int id)
	{
		books[id] = temp;
		
	}
}
