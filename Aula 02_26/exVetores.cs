using System;

class MainClass {
  public static void Main() {
    /*
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    int[] w = new int[10];
    int[] x = new int[15];
    Array.Copy(v, w, 5);
    v.CopyTo(x, 2);
    foreach (int i in x)
      Console.WriteLine(i);
      
int[] v = { 10, 8, 6, 4, 2, 1, 3, 5, 7, 9 };
int p1 = Array.IndexOf(v, 5);
int p2 = Array.IndexOf(v, 10);
int p3 = Array.IndexOf(v, 15);
Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);  
*/
    int[] v = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    //Array.ForEach(v, i => Console.WriteLine(i * i));
    Array.ForEach(v, Mostrar);
    Console.ReadKey();
  }

  public static void Mostrar(int i) {
    Console.WriteLine(i * i);
  }
}
