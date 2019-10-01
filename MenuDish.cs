namespace ChefHelper
{
  public class MenuDish
  {
    public string dishName;
    public string[] ingredients = new string[4];
    public double[] quantities = new double[4];
    public string[] units = new string[4];

    public MenuDish(int dishChoice)
    {
      switch (dishChoice)
      {
        case 1:
          dishName = "Butter Chicken";
          for (int i = 0; i < 4; i++)
          {
            ingredients[i] = new string[] { "Chicken breast", "Olive oil", "Crushed tomatoes", "Plain yoghurt" }[i];
            quantities[i] = new double[] { 250, 3, 15, 16 }[i];
            units[i] = new string[4] { "grams", "tbs", "oz", "fl oz" }[i];
          }
          break;
        case 2:
          dishName = "Chicken Pasta";
          for (int i = 0; i < 4; i++)
          {
            ingredients[i] = new string[] { "Chicken", "Linguine pasta", "Bechamel sauce", "Parmigiano cheese" }[i];
            quantities[i] = new double[] { 150, 400, 300, 50 }[i];
            units[i] = new string[4] { "grams", "grams", "ml", "grams" }[i];
          }
          break;
        case 3:
          dishName = "Spicy Beef";
          for (int i = 0; i < 4; i++)
          {
            ingredients[i] = new string[] { "Beef", "Gravy sauce", "Ground pepper", "Chilli" }[i];
            quantities[i] = new double[] { 300, 120, 20, 20 }[i];
            units[i] = new string[4] { "grams", "ml", "grams", "grams" }[i];
          }
          break;
      }
    }
  }
}