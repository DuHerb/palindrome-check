using System;

using System.Collections.Generic;

namespace Palindrome
{

  class Program
  {

  static void Main()
    {
      Console.WriteLine("Give us a word and we will tell you if it's a palindrome");
      string userWord = Console.ReadLine();
      char[] userArray = userWord.ToCharArray();

      foreach (char ch in userArray)
      {
      Console.WriteLine(ch);
      }

      Array.Reverse(userArray);
      string reversedWord  = new string(userArray);

      Console.WriteLine( "After reversing:" );
      Console.WriteLine( reversedWord );

      if (reversedWord == userWord)
      {
        Console.WriteLine("Palindrome");
      }
      else
      {
        Console.WriteLine("nope");
      }

    }
  }
}
