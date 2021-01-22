using System;

class MainClass {
  public static void Main() { 

    int x = 10;
/*
    Console.WriteLine(x);
    x++;
    Console.WriteLine(x);
    x++;
    Console.WriteLine(x);
    x++;
    Console.WriteLine(x);
    x++;
    Console.WriteLine(x);
    x++;
*/
    while (x <= 5) {
      Console.WriteLine(x);
      x++;
    }

    for (x = 10; x <= 5; x++)
      Console.WriteLine(x);

    x = 10;
    do {
      Console.WriteLine(x);
      x++;
    } while (x <= 5);

  }
}