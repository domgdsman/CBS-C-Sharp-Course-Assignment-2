namespace ChefHelper
{
  public static class User
  {
    private static string username = "SuperChef";
    private static string password = "password";
    public static bool CheckCredentials(string usernameInput, string passwordInput)
    {
      return usernameInput == username && passwordInput == password;
    }
  }
}