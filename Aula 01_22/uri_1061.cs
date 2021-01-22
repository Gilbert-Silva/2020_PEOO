using System;

class MainClass {
  public static void Main() { 
    string dia1 = Console.ReadLine();
    string horario1 = Console.ReadLine();
    string dia2 = Console.ReadLine();
    string horario2 = Console.ReadLine();

    int d1 = int.Parse(dia1.Substring(4));
    int h1 = int.Parse(horario1.Substring(0, 2));
    int m1 = int.Parse(horario1.Substring(5, 2));
    int s1 = int.Parse(horario1.Substring(10, 2));

    int d2 = int.Parse(dia2.Substring(4));
    int h2 = int.Parse(horario2.Substring(0, 2));
    int m2 = int.Parse(horario2.Substring(5, 2));
    int s2 = int.Parse(horario2.Substring(10, 2));

    int t1 = d1 * 86400 + h1 * 3600 + m1 * 60 + s1;
    int t2 = d2 * 86400 + h2 * 3600 + m2 * 60 + s2;

    int dif = t2 - t1;

    int nd = dif / 86400;
    dif = dif % 86400;

    int nh = dif / 3600;
    dif = dif % 3600;

    int nm = dif / 60;
    dif = dif % 60;
     
    Console.WriteLine($"{nd} dia(s)");
    Console.WriteLine($"{nh} hora(s)");
    Console.WriteLine($"{nm} minuto(s)");
    Console.WriteLine($"{dif} segundo(s)");
  }
}
