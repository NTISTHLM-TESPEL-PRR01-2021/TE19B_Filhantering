using System;
using System.IO;

namespace Filhantering
{
  class Program
  {
    static void Main(string[] args)
    {

      // string message = "Detta är en rolig text";

      // string fileName = @"text\scen3.txt";

      // if (File.Exists(fileName))
      // {
      //   string[] rows = File.ReadAllLines(fileName);
      //   Console.WriteLine(rows[0]);
      // }

      // File.Move("message.txt", @"message-old.txt");


      // File.WriteAllText(fileName, message);

      // string message = File.ReadAllText(fileName);

      // string[] rows = message.Split("\n");

      string fileName = "enemies.csv";
      string[] rows = File.ReadAllLines(fileName);

      // Console.WriteLine(rows[1]);

      for (int i = 1; i < rows.Length; i++)
      {
        string[] enemyInfo = rows[i].Split(",");
        Console.WriteLine(enemyInfo[1]);
      }




      Console.ReadLine();
    }
  }
}
