using System;

class MainClass {
  public static void Main() {
    double v1 = 10;
    double v2 = 20;
    double v3 = Maior(v1, v2);
    Console.WriteLine("Questão 01");
    Console.WriteLine(v1);
    Console.WriteLine(v2);
    Console.WriteLine(v3);
    Console.WriteLine(Maior(50, 20));
    Console.WriteLine(Math.Max(50, 20));
    Console.WriteLine("Questão 02");
    int a = 1;
    int b = 5;
    int c = 3;
    Ordenar(ref a, ref b, ref c);
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    Console.WriteLine("Questão 03");
    double x = 4.3;
    int y;
    int z;
    Intervalo(x, out y, out z);
    Console.WriteLine(y);
    Console.WriteLine(z);
    // Exemplo de Parse
    Console.WriteLine("Digite um valor");
    int v = 0;
    while (int.TryParse(Console.ReadLine(), out v) == false)
      Console.WriteLine("Valor informado não é um inteiro. Digite novamente!");
    Console.WriteLine(v);
  }

  public static void Intervalo(double x, out int inicio, out int fim)
  {
    // 4.3 -> 4
    // 4.0 -> 4
    inicio = (int) x;
    fim = inicio + 1;
  }

  public static void Ordenar(ref int x, ref int y, ref int z)
  {
    // selection sort
    int aux;
    // x com y
    if (x > y) {
      aux = x;
      x = y;
      y = aux;
    } 
    // x com z
    if (x > z) {
      aux = x;
      x = z;
      z = aux;
    } 
    // y com z
    if (y > z) {
      aux = y;
      y = z;
      z = aux;
    } 
  }

  public static double Maior(double x, double y) {
    double a = x;
    if (y > x) a = y;
    //x = 1;
    //y = 2;
    return a;
  }
}
