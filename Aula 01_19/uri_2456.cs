using System;

class MainClass {
  public static void Main() {
    string s = Console.ReadLine();
    string[] v = s.Split(' ');
    int a = int.Parse(v[0]);
    int b = int.Parse(v[1]);
    int c = int.Parse(v[2]);
    int d = int.Parse(v[3]);
    int e = int.Parse(v[4]);

    if (a < b && b < c && c < d && d < e)
      Console.WriteLine("C");
    else
      if (a > b && b > c && c > d && d > e)
        Console.WriteLine("D");
      else  
        Console.WriteLine("N");
  }
}