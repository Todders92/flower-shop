using System;
using System.Collections.Generic;
using PlantShop.Models;

namespace PlantShop
{
  public class Program
  {
    public static void Main()
    {
      Bouquet bouqeut = new Bouquet( "0", 0, 0);
      Console.WriteLine("enter the size of vase you would like to buy");
      string response = Console.ReadLine();
      int sizeNumber = bouqeut.AddSize(response);
      Console.WriteLine(sizeNumber);
      Console.WriteLine("bouquet size is " + bouqeut.Size);
      Console.WriteLine("bouquet price is " + bouqeut.Price);
      Console.WriteLine("what color flowers would you like?");
      string colorResponse = Console.ReadLine();
      bouqeut.AddColor(colorResponse);
      int colorMulitplier = bouqeut.AddColor(colorResponse);
      Console.WriteLine("your flower colors are " + bouqeut.Color);
      Console.WriteLine("How many flowers would you like in your bouquet?");
      string stringNumber = Console.ReadLine();
      int number = int.Parse(stringNumber);
      bouqeut.AddNumber(number);
      Console.WriteLine("the number of flowers in your order is " + bouqeut.NumberOfFlowers);
      bouqeut.AddPrice(sizeNumber , number , colorMulitplier);
      Console.WriteLine("your order total is $" + bouqeut.Price);
    }
  }
}