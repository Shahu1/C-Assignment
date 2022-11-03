using System;
namespace Assignment6
{ 
struct BOOKS
{
	public int book_id;
	public string Title;
	public int price;

		enum bookType
        {
			Magazine,
			Novel,
			ReferenceBook,
			Miscellaneous
        }
};
public class StructureClass
{
	public static void Main(string[] args)
	{
            Console.WriteLine("Enter Details of book1");
            Console.WriteLine("Enter book id");
			int book_id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Title of the book1");
			string Title = Console.ReadLine();
            Console.WriteLine("Enter price of book 1");
			int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select type of book");
			string bookType = Convert.ToString(Console.ReadLine());


            Console.WriteLine(" ");
            Console.WriteLine("Your Entered BOOk Details Are...");
			Console.WriteLine("Book 1\n Id  = {0}", book_id);
			Console.WriteLine("Title = {0}", Title);
			Console.WriteLine("price = {0}", price);
			Console.WriteLine("bookType = {0}", bookType);
		


			Console.ReadLine();

	}
}
}
