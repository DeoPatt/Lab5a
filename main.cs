using System;

class MainClass {
  public static void Main (string[] args) {
    int counter = 1;
    while (counter <= 7)
    {
      Console.WriteLine("Enter the distance covered by car" + "#" + counter);
      double distance = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the time taken by car" + "#" + counter);
      double time = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("The speed of car #" + counter + " is " + distance/time);
    counter++;
    }
  }
}