using System.Diagnostics;
// See https://aka.ms/new-console-template for more information
using System;
using Enemies;
using System.Drawing.Printing;


namespace Game
{
  class Program
  {
    static void Main(string[] args)
    {
      
      Console.WriteLine("What's your first name?");
      string first_name = Console.ReadLine();
      
      Console.WriteLine("What's your last name?");
      string last_name = Console.ReadLine();

      Thread.Sleep(200);

      Console.WriteLine($"hello {first_name} {last_name}, you suck");


      Console.WriteLine("product price: ");
      float price = Convert.ToSingle(Int32.Parse(Console.ReadLine()));

      Console.WriteLine("amount: ");
      int amount = Int32.Parse(Console.ReadLine());

      float cost = amount * price;

      Console.WriteLine(price);







    }
  }
}