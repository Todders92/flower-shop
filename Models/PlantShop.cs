using System;
using System.Collections.Generic;

namespace PlantShop.Models
{
  public class Bouquet
  {
    public string Size { get; set; }
    public string Color { get; set; }
    public int NumberOfFlowers { get; set; }
    public int Price { get; set; }
    
    public Bouquet( string color, int numberOfFlowers, int price)
    {
      Size = "none";
      Color = color;
      NumberOfFlowers = numberOfFlowers;
      Price = price;
    }
    public int AddSize(string size)
    {
      if(size == "small")
      {
        Size = "small";
        return 10;
      }
      else if(size == "medium")
       {
         Size = "medium";
         return 12;
       }
      else 
      {
        Size = "large";
        return 14;
      }
    }
    public int AddColor(string color)
    {
      if(color == "red")
      {
        Color = "red";
        return 1;
      }
      else if (color == "blue")
      {
        Color = "blue";
        return 2;
      }
      else if (color == "pink")
      {
        Color = "pink";
        return 1;
      }
      else if (color == "yellow")
      {
        Color = "yellow";
        return 1;
      }
      else if (color == "purple")
      {
        Color = "purple";
        return 1;
      }
      else
      {
        Color = "white";
        return 1;
      }
    }
    public void AddNumber(int number)
    {
    NumberOfFlowers = number;
    }
    
    public void AddPrice(int size , int numberOfFlowers, int color)
    {
      Price += (size  + numberOfFlowers) * color;
    }

  }
}
