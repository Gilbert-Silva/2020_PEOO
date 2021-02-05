using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Digite uma frase");
    string texto = Console.ReadLine();
    Console.WriteLine("Digite a posição da palavra a ser localizada");
    int pos = int.Parse(Console.ReadLine());

    Console.WriteLine(Palavra(texto, pos));
  }

  public static string Palavra(string texto, int pos)
  {
    string[] v = texto.Split(' ');
    if (pos < 0 || pos >= v.Length) 
      return "Posição inválida";
    else
      return v[pos];
  }

}
