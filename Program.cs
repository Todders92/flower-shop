using System;
using System.Collections.Generic;
using PlantShop.Models;

namespace PlantShop
{
  public class Program
  {
    public static void Main()
    {
      Bouquet bouqeut = new Bouquet( "0", 0, 10);
      Console.WriteLine("enter the size of vase you would like to buy");
      string response = Console.ReadLine();
      bouqeut.AddSize(response);
      Console.WriteLine("bouquet size is " + bouqeut.Size);
      Console.WriteLine("bouquet price is " + bouqeut.Price);
      Console.WriteLine("what color flowers would you like?");
      string colorResponse = Console.ReadLine();
      bouqeut.AddColor(colorResponse);
      Console.WriteLine("your flower colors are " + bouqeut.Color);
      Console.WriteLine("How many flowers would you like in your bouquet?");
      string stringNumber = Console.ReadLine();
      int number = int.Parse(stringNumber);
      bouqeut.AddNumber(number);
      Console.WriteLine("the number of flowers in your order is " + bouqeut.NumberOfFlowers);
      bouqeut.AddPrice(1, number , 1);
      Console.WriteLine("your order total is $" + bouqeut.Price);
    }
  }
}