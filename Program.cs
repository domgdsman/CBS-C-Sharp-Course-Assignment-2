using System;

namespace ChefHelper
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please provide password to access the ChefHelper");
      string usernameInput = Console.ReadLine();

      Console.WriteLine("Please provide password to access the ChefHelper");
      string passwordInput = Console.ReadLine();

      if (User.CheckCredentials(usernameInput, passwordInput))
      {
        System.Console.WriteLine(@"****** Here are our food dishes ******
Please select the dish to see ingredients.
1. Butter Chicken
2. Chichen Pasta
3. Spicy Beef");

        int dishChoice = int.Parse(Console.ReadLine());

        // Object properties for MenuDish class constructor
        string[] dishName = new string[1]; // dirty fix: c# does not let one create an object with unassigned string
        string[] ingredients = new string[4];
        double[] quantities = new double[4];
        string[] units = new string[4];

        switch (dishChoice)
        {
          case 1:
            dishName[0] = "Butter Chicken";
            for (int i = 0; i < 4; i++)
            {
              ingredients[i] = new string[] { "Chicken breast", "Olive oil", "Crushed tomatoes", "Plain yoghurt" }[i];
              quantities[i] = new double[] { 250, 3, 15, 16 }[i];
              units[i] = new string[4] { "grams", "tbs", "oz", "fl oz" }[i];
            }
            break;
          case 2:
            dishName[0] = "Chicken Pasta";
            for (int i = 0; i < 4; i++)
            {
              ingredients[i] = new string[] { "Chicken", "Linguine pasta", "Bechamel sauce", "Parmigiano cheese" }[i];
              quantities[i] = new double[] { 150, 400, 300, 50 }[i];
              units[i] = new string[4] { "grams", "grams", "ml", "grams" }[i];
            }
            break;
          case 3:
            dishName[0] = "Spicy Beef";
            for (int i = 0; i < 4; i++)
            {
              ingredients[i] = new string[] { "Beef", "Gravy sauce", "Ground pepper", "Chilli" }[i];
              quantities[i] = new double[] { 300, 120, 20, 20 }[i];
              units[i] = new string[4] { "grams", "ml", "grams", "grams" }[i];
            }
            break;
        }

        // Using class constructor to create dish object
        MenuDish chosenDish = new MenuDish(dishName, ingredients, quantities, units);

        Console.WriteLine("Please provide number of guest.");
        int numberOfGuests = int.Parse(Console.ReadLine());

        Console.WriteLine($"**Here are ingredients for {chosenDish.dishName} for {numberOfGuests} persons**");
        for (int i = 0; i < 4; i++)
        {
          Console.WriteLine($"{chosenDish.ingredients[i]} : {chosenDish.quantities[i] * numberOfGuests} {chosenDish.units[i]}");
        }
      }
      else
      {
        System.Console.WriteLine("You are not authorized to access this service");
      }
    }
  }
}