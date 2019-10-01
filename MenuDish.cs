using System;

namespace ChefHelper
{
  public class MenuDish
  {
    public string dishName;
    public string[] ingredients = new string[4];
    public double[] quantities = new double[4];
    public string[] units = new string[4];

    public MenuDish(string[] name, string[] ingredientsArr, double[] quantitiesArr, string[] unitsArr)
    {
      dishName = name[0];
      for (int i = 0; i < 4; i++)
      {
        ingredients[i] = ingredientsArr[i];
        quantities[i] = quantitiesArr[i];
        units[i] = unitsArr[i];
      }
    }
  }
}