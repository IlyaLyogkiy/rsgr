using System;
using System.Collections;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
     
      string[] text ={"VALERA",
        "LOVE",
        "pizza",
        " valerazhmyshenko@mail.ru",
        " valerazhmyshenko@gmail.com",
        " valerazhmyshenko@bk.ru" };

      string str56 = @"c:\pizza;
      Console.WriteLine(str56);
  


      foreach (string item in text)
      {
        string pattern = @"\w +[@]\w +[.]\w + ";
        if (Regex.IsMatch(item, pattern))
        {

          Console.WriteLine(item + " почта");
        }
        else
        {
          Console.WriteLine(
          string.Format("{0} это НЕ почта", item)
          );
        }
      }
      Console.ReadLine();
    }
  }
}