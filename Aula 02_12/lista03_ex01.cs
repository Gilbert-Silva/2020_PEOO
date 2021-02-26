using System;

class MainClass {
  public static void Main() {
    Retangulo r = new Retangulo();
    Retangulo s = new Retangulo(50, 80);
    r = s;
    r.SetBase(100);
    r.SetAltura(200);
    //Console.WriteLine(r.ToString());
    Console.WriteLine(r);
    Console.WriteLine(s);
  }
}

class Retangulo {
  private double b = 10, h = 20;
  public Retangulo() { }
  public Retangulo(double b, double h) {
    if (b > 0) this.b = b;
    if (h > 0) this.h = h;
  }
  public void SetBase(double b) {
    if (b > 0) this.b = b;
  }
  public void SetAltura(double h) {
    if (h > 0) this.h = h;
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
}