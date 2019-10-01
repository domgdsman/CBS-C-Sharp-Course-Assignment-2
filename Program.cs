using System;

namespace ChefHelper
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Please provide username to access the ChefHelper");
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

        int dishChoice;
        while (!int.TryParse(Console.ReadLine(), out dishChoice) || dishChoice < 1 || dishChoice > 3)
        {
          Console.WriteLine("Please provide a number from the menu.");
        }

        // Using class constructor to create dish object
        MenuDish chosenDish = new MenuDish(dishChoice);

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