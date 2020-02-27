using System;
using System.Collections.Generic;

namespace PlantShop.Models
{
  public class Bouquet
  {
    public int Size { get; set; }
    public string Color { get; set; }
    public int NumberOfFlowers { get; set; }
    public int Price { get; set; }
    
    public Bouquet( string color, int numberOfFlowers, int price)
    {
      Size = 0;
      Color = color;
      NumberOfFlowers = numberOfFlowers;
      Price = price;
    }
    public void AddSize(string size)
    {
      if(size == "small")
      {
        Size = 1;
      }
      else if(size == "medium")
       {
         Size = 2;
       }
      else if (size == "large")
      {
        Size = 3;
      }
    }
    public void AddColor(string color)
    {
      if(color == "red")
      {
        Color = "red";
      }
      else if (color == "blue")
      {
        Color = "blue";
      }
      else if (color == "pink")
      {
        Color = "pink";
      }
      else if (color == "yellow")
      {
        Color = "yellow";
      }
      else if (color == "purple")
      {
        Color = "purple";
      }
      else if (color == "white")
      {
        Color = "white";
      }
    }
    public void AddNumber(int number)
    {
    NumberOfFlowers = number;
    }
    // public void ConvertItems(string size)
    // {
    //   if(size == "small")
    //   {
    //     size = "10";
    //     int newsize = int.Parse(size);
    //     // Console.WriteLine(newsize);
    //   }
    // }
    public void AddPrice(int size , int color, int numberOfFlowers)
    {
      Price += size + color + numberOfFlowers;
    }

  }
}