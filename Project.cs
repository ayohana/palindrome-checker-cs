using System;
using System.Collections.Generic;

public class Project
{
  public static bool IsPalindrome(string input) 
  {
    int length = input.Length;
    if (length <= 1)
    {
      return true;
    }
    if (input[0] == input[length - 1])
    {
      return IsPalindrome(input.Substring(1,length - 2));
    }
    else {
      return false;
    }
  }

  public static void Main()
  {
    Console.WriteLine("Enter a word");
    string input = Console.ReadLine();
    if (IsPalindrome(input)) 
    {
      Console.WriteLine(input + " is a palindrome.");
    } 
    else 
    {
      Console.WriteLine(input + " is not a palindrome.");
    }
  }
}