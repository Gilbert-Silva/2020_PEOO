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
    int f = int.Parse(v[5]);

    s = Console.ReadLine();
    v = s.Split(' ');
    int g = int.Parse(v[0]);
    int h = int.Parse(v[1]);
    int i = int.Parse(v[2]);
    int j = int.Parse(v[3]);
    int k = int.Parse(v[4]);
    int l = int.Parse(v[5]);

    int x = 0;

    if (a == g || a == h || a == i || a == j || a == k || a == l) x++;   
    if (b == g || b == h || b == i || b == j || b == k || b == l) x++;   
    if (c == g || c == h || c == i || c == j || c == k || c == l) x++;   
    if (d == g || d == h || d == i || d == j || d == k || d == l) x++;   
    if (e == g || e == h || e == i || e == j || e == k || e == l) x++;   
    if (f == g || f == h || f == i || f == j || f == k || f == l) x++;   
 
    if (x == 3) Console.WriteLine("terno");
    if (x == 4) Console.WriteLine("quadra");
    if (x == 5) Console.WriteLine("quina");
    if (x == 6) Console.WriteLine("sena");
    if (x < 3) Console.WriteLine("azar");
  }
}