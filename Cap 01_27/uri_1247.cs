using System;

class MainClass {
  public static void Main() {
    string s;
    while (string.IsNullOrEmpty(s = Console.ReadLine()) == false) {
      
      string[] v = s.Split(' ');
      Console.WriteLine(v[0]);
      Console.WriteLine(v[1]);
      Console.WriteLine(v[2]);

    }
    // Em C++
    // while (cin >> s) {

    // }
  }
}