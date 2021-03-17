using System;

class MainClass {
  public static void Main() {
    Conversao c = new Conversao(57);
    Console.WriteLine(c.Binario());
    Console.WriteLine(c);
    c.SetNum(19);
    Console.WriteLine(c.Binario());
    Console.WriteLine(c);
    c.SetNum(1024);
    Console.WriteLine(c.Binario());
    Console.WriteLine(c);

    Paciente p = new Paciente();
    p.Nascimento = DateTime.Parse("2000-04-01");
    Console.WriteLine(p.Idade);
    Console.WriteLine(p.GetIdade());
  }
}

class Paciente {
  private DateTime nascimento;
  public DateTime Nascimento {
    get => nascimento; // expression-body
    set { nascimento = value; }
  }
  public string Idade {
    get {
      DateTime hoje = DateTime.Now;
      int anos = hoje.Year - nascimento.Year;
      int meses = hoje.Month - nascimento.Month;
      if (meses < 0) {
        anos--;
        meses += 12;
      }
      return $"{anos} ano(s) e {meses} mes(es)";
    }
  }
  public string GetIdade() {
    DateTime hoje = DateTime.Now;
    int anos = hoje.Year - nascimento.Year;
    int meses = hoje.Month - nascimento.Month;
    if (meses < 0) {
      anos--;
      meses += 12;
    }
    return $"{anos} ano(s) e {meses} mes(es)";
  }

}

class Conversao {
  private int num;
  public Conversao(int num) {
    this.num = num;
  }
  public void SetNum(int num) {
    this.num = num;
  }
  public int GetNum() {
    return num;
  }
  public string Binario() {
    string s = "";
    int q = num;
    while (q != 0) {
      int r = q % 2;
      s = r.ToString() + s;
      q = q / 2;
    }
    return s;
  }
  public override string ToString() {
    return $"Decimal = {num} Binário = {Binario()}";
  }
}