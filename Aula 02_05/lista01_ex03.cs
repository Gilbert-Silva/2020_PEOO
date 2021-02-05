using System;

class MainClass {
  public static void Main() {
    Viagem v;         // referência para um objeto
    v = new Viagem(); // Objeto da classe Viagem
    Console.WriteLine("Informe a distância da viagem");
    v.distancia = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o tempo no formato hh:mm");
    string s = Console.ReadLine();
    v.horas = double.Parse(s.Substring(0,2));
    v.minutos = double.Parse(s.Substring(3,2));
    Console.WriteLine($"Velocidade média = {v.CalcVelocidade():0.00} km/h");    
  }
}

class Viagem {
  public double distancia;
  public double horas;
  public double minutos;
  public double CalcVelocidade() {
    double tempo = horas + minutos/60;
    double veloc = distancia/tempo;
    return veloc;
  }
}