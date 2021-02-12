using System;

class MainClass {
  public static void Main() {
    Viagem v;         // referência para um objeto
    v = new Viagem(); // Objeto da classe Viagem

    Console.WriteLine("Informe a distância da viagem");
    double distancia = double.Parse(Console.ReadLine());

    v.SetDistancia(distancia);

    Console.WriteLine("Informe o tempo no formato hh:mm");
    string s = Console.ReadLine();
    double tempo = 
      double.Parse(s.Substring(0,2)) +    // horas
      double.Parse(s.Substring(3,2))/60;  // minutos

    v.SetTempo(tempo);
    v.SetTempo(
      int.Parse(s.Substring(0,2)),
      int.Parse(s.Substring(3,2)));

    Console.WriteLine($"Velocidade média = {v.CalcVelocidade():0.00} km/h");    
  }
}

class Viagem {
  private double distancia;
  private double tempo;
  public void SetDistancia(double d) {
    if (d >= 0) distancia = d;
    else throw new ArgumentOutOfRangeException("Distância Inválida");
  }
  // Sobrecarga de métodos
  public void SetTempo(double t) {
    if (t > 0) tempo = t;
  }
  public void SetTempo(int h, int m) {
    if (h >= 0 && m >=0) tempo = h + m/60.0;
  }
  public double GetDistancia() {
    return distancia;
  }
  public double GetTempo() => tempo;
  
  public double CalcVelocidade() {
    double veloc = distancia/tempo;
    return veloc;
  }
}