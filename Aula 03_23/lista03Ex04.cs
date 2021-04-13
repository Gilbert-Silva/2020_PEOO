using System;

class MainClass {
  public static void Main() {
    Console.WriteLine("Digite os coeficientes da equação");
    double a, b, c;
    while (double.TryParse(Console.ReadLine(), out a) == false) 
      Console.WriteLine("Valor inválido");
    while (double.TryParse(Console.ReadLine(), out b) == false) 
      Console.WriteLine("Valor inválido");
    while (double.TryParse(Console.ReadLine(), out c) == false) 
      Console.WriteLine("Valor inválido");
    Equacao x = new Equacao(1, 0, -4);
    Console.WriteLine($"Delta = {x.Delta()}");
    double x1, x2;
    if (x.RaizesReais(out x1, out x2)) 
      Console.WriteLine($"X1 = {x1} e X2 = {x2}");
    else
      Console.WriteLine($"Não tem raízes reais");
    //x.GetABC(out a, out b, out c);
    (a, b, c) = x.GetABC();
    Console.WriteLine($"{a} {b} {c}");
  }
}

class Equacao {
  private double a, b, c;
  public Equacao(double a, double b, double c) {
    this.a = a != 0 ? a : 1;
    this.b = b;
    this.c = c;
  }
  public void SetA(double a) {
    this.a = a != 0 ? a : 1;
  }
  public void SetB(double b) {
    this.b = b;
  }
  public void SetC(double c) {
    this.c = c;
  }
  public void SetABC(double a, double b, double c) {
    this.a = a != 0 ? a : 1;
    this.b = b;
    this.c = c;
  }
  public double GetA() {
    return a;
  }
  public double GetB() {
    return b;
  }
  public double GetC() {
    return c;
  }
  public void GetABC(out double a, out double b, out double c) {
    a = this.a;
    b = this.b;
    c = this.c;
  }
  public (double a, double b, double c) GetABC() { // Tupla
    return (this.a, this.b, this.c);
  }
  public double Delta() {
    return b*b - 4*a*c;
  }
  public bool RaizesReais(out double x1, out double x2) {
    x1 = 0;
    x2 = 0;
    if (Delta() < 0) return false;
    x1 = (-b + Math.Sqrt(Delta())) / (2*a);
    x2 = (-b - Math.Sqrt(Delta())) / 2 / a;
    return true;
  }
}
