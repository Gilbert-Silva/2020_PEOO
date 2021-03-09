using System;

class MainClass {
  public static void Main() {
    Retangulo r = new Retangulo();
    r.Base = 3;
    r.Altura = 4;
    //r.Area = 10;
    Console.WriteLine(r);
    Console.WriteLine(r.Area);
    Console.WriteLine(r.Diagonal);
  }
}

class Retangulo {
  private double b, h;
  public double Base {
    get { return b; }
    set { if (value > 0) b = value; }  
  }
  public double Altura {
    get => h;
    set => h = value > 0 ? value : 0;
  }
  public double Area {
    get { return b * h; }
  }
  public double Diagonal {
    get => Math.Sqrt(b*b + h*h);
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
}