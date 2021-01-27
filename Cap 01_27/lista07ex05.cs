using System;

class MainClass {
  public static void Main() {
    string s = Console.ReadLine();
    /*
    s = s.Trim();
    int p = s.IndexOf("  ");
    while (p != -1) {
      s = s.Remove(p, 1);
      p = s.IndexOf("  ");
    }
    Console.WriteLine(s);
    */
    Console.WriteLine(FormatarTexto(s));

  }

  public static string FormatarTexto(string texto)
  {
    string s = texto;
    s = s.Trim();
    int p = s.IndexOf("  ");
    while (p != -1) {
      s = s.Remove(p, 1);
      p = s.IndexOf("  ");
    }
    return s;
  }
}