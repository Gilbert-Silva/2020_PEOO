using System;

class MainClass {
  public static void Main() {
    string s = Console.ReadLine();
    while (s != "*") {
      s = s.ToLower();
      char c = s[0];
      bool ok = true;
      for (int i = 1; i < s.Length; i++)
        if (s[i] == ' ' && s[i+1] != c) ok = false;
      if (ok) Console.WriteLine("Y");
      else Console.WriteLine("N");
      s = Console.ReadLine();
    }
  }
}