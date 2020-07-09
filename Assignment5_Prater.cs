/* Brie Prater
07/02/2020
CIS 353
Professor Cain
Assignment 5.2 */

using System;
namespace CIS353
{
	public class Book // public class Book
	{
		protected string title; // protected variable
		protected string author; // protected variable
		public void book() // class method
		{
			string input; // variable to hold user input
			Console.WriteLine("Do you want to enter a Fiction (F) or Non-Fiction (N) book?");
			input = Console.ReadLine(); // obtaining user input
			if (input == "F" || input == "f") // determining user selection for fiction
			{
				Console.WriteLine("You have selected Fiction and will indicate the reading level of the book.");
				Fiction chose = new Fiction(); // instantiates Fiction class method
				chose.fict(); // calls method
			}
			else if (input == "N" || input == "n") // determining user selection for non-fiction
			{
				Console.WriteLine("You have selected Non-Fiction and will indicate the number of pages in the book.");
				NonFiction chose = new NonFiction(); // instantiates NonFiction class method
				chose.non(); // calls method
			}
			else
			{
				Console.WriteLine("Please use F or f to indicate Fiction, or N or n to indicate Non-Fiction."); // alerts input is incorrect
			}
		}
	}
	public class Fiction : Book // child class Fiction of parent class Book
	{
		private string readLvl; // private variable
		public string Level
		{
			get { return readLvl; }
			set { readLvl = value; } // enables public methods to access private variable
		}
		public void fict() // class method
		{
			Fiction x = new Fiction(); // instantiates Fiction class method
			Console.WriteLine("Please enter the book title: ");
			x.title = Console.ReadLine(); // stores user input for title
			Console.WriteLine("Please enter the book author: ");
			x.author = Console.ReadLine(); // stores user input for author
			Console.WriteLine("Please enter the reading level: ");
			Level = Console.ReadLine(); // stores user input for reading level
			Console.WriteLine("The book you have entered is {0} by {1} with a reading level of {2}.", x.title, x.author, Level); // display book information by passing variables
		}
	}
	public class NonFiction : Book // child class NonFiction of parent class Book
	{
		private string numPages; // private variable
		public string Pages
		{
			get { return numPages; }
			set { numPages = value; } // enables public methods to access private variable
		}
		public void non() // class method
		{
			NonFiction z = new NonFiction(); // instantiates NonFiction class method
			Console.WriteLine("Please enter the book title: ");
			z.title = Console.ReadLine(); // stores user input for title
			Console.WriteLine("Please enter the book author: ");
			z.author = Console.ReadLine(); // stores user input for author
			Console.WriteLine("Please enter the number of pages: ");
			Pages = Console.ReadLine(); // stores user input for number of pages
			Console.WriteLine("The book you have entered is {0} by {1} with {2} pages.", z.title, z.author, Pages); // displays book information by passing variables
		}
	}
	public class Test
	{
		public static void Main(string[] args) // main method
		{
			string menu; // variable to hold user input
			Book a = new Book(); // instantiates Book class method
			a.book(); // calls method
			Console.WriteLine("To continue enter X or x: "); // determines if user wants to continue
			menu = Console.ReadLine(); // stores user input
			if (menu == "X" || menu == "x") // determines if user entered X
			{
				a.book(); // if true calls Book class method
			}
			else
			{
				Console.WriteLine("Good Bye!"); // if not terminates program
			}
		}
	}
}