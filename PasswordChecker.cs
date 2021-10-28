using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
      string lowercase = "qwertyuiopasdfghjklzxcvbnm";
      string digits = "0123456789";
      string specialChars = "!@#$%^&*?<>";

      Console.WriteLine("Enter a password: ");
      string password = Console.ReadLine();

      int score = 0;
      
      if (password.Length >= minLength)
      {
        score += 1;
      }

      if (Tools.Contains(password, uppercase))
      {
        score += 1;
      }

      if (Tools.Contains(password, lowercase))
      {
        score += 1;
      }

      if (Tools.Contains(password, digits))
      {
        score += 1;
      }

      if (Tools.Contains(password, specialChars))
      {
        score += 1;
      }

      //Console.WriteLine(score);
      switch (score)
      {
        case 5:
          Console.WriteLine($"{password} scores a 5.Extremely strong!");
          break;
        case 4:
          Console.WriteLine($"{password} scores a 4. Extremely strong!");
          break;
        case 3:
          Console.WriteLine($"{password} scores a 3. Strong.");
          break;
        case 2:
          Console.WriteLine($"{password} scores a 2. Medium.");
          break;
        case 1:
          Console.WriteLine($"{password} scores a 1. Weak.");
          break;
        default:
          Console.WriteLine($"{password} scores a 0. It doesn't meet any of the standards.");
          break;
      } 

    }
  }
}
