using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Library : MonoBehaviour
{
	
	[SerializeField] private Button replacer;
	
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
	static Book book0 = new Book ("book1", "pepe", 200, 1999, "fiction", "used", "green");
	

	
	void Update()
	{
		ActivateReplacer();
		
	}
	
	void Start()
	{
		Application.targetFrameRate = 30;
		
		books[0] = book0;
		
		CheckCapacity();
		Debug.Log("Capacity is: " + capacity );
		
	}
	
	public void ModifyArray(Book temp, int id)
	{
		ReplaceBook(temp, toReplace);
		CheckCapacity();

	
	}
	
	public void ModifyArray(Book newBook)
	{
		CheckCapacity();
		
		if (currentBooks >= capacity)
		{
			Debug.Log("Capacity Exeeded, a book must be replaced");
			ModifyArray(newBook, toReplace);
				
		}else
		{
			AddBook(newBook, currentBooks);
			
			}
	}
	
	public void ShowBooks()
	{/*
		for (int i = 0; i < currentBooks; i++) 
		{
			if (books[i] != null)
			{
				Debug.Log("Book"+i+" is: "+books[i].Title+" By: "+ books[i].Author+", " +books[i].Pages+
				" Pages Long, " + "published in: " + books[i].year + "Genre: " + books[i].genre +
				" Condition: "+books[i].condition+"Color: "+books[i].color);
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
				currentBooks += 1;
				Debug.Log("Current Books: " + currentBooks);
			}
		}
	}
	

	
	public void CreateBook(string title, string author, int pages, int year, string genre, string condition, string color)
	{
		Book newBook = new Book (title,author,pages, year, genre, condition, color);
		ModifyArray(newBook);
		
	}
	
	public void ActivateReplacer()
	{
		if (currentBooks >= capacity)
		{
			replacer.enabled = true;
		}else{replacer.enabled = false;}
		
		
	}
	
	void ReplaceBook(Book newBook, int id)
	{
		books[toReplace] = newBook;
		
	}
	

}
