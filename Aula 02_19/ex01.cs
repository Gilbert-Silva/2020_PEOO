using System;
using System.Threading;
using System.Globalization;

class MainClass {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");

    Compra c = new Compra(100.03, 3);
    Console.WriteLine(c);
    Console.WriteLine(c.ToString());
    Console.WriteLine(c.CalcPrimeiraParcela());
    Console.WriteLine(c.CalcOutrasParcelas());
  }
}

class Compra {
  private double valor;
  private int numParcelas = 1;
  public Compra(double valor, int numParcelas) {
    if (valor > 0) this.valor = valor;
    if (numParcelas > 0) this.numParcelas = numParcelas;
  }
  public void SetValor(double valor) {
    if (valor > 0) this.valor = valor;
  }
  public void SetNumParcelas(int numParcelas) {
    if (numParcelas > 0) this.numParcelas = numParcelas;
  }
  public double GetValor() {
    return valor;
  }
  public int GetNumParcelas() {
    return numParcelas;
  }
  public double CalcPrimeiraParcela() {
    return CalcOutrasParcelas() + 
           valor - numParcelas * CalcOutrasParcelas();
  }
  public double CalcOutrasParcelas() {
    // 33.333333333333
    // 3333.3333333333
    // 3333.0000000000
    // 33.33
    //return Math.Truncate(valor/numParcelas * 100) / 100;
    return ( (int) (valor/numParcelas * 100 + 0.000001) ) / 100.0;
  }
  public override string ToString() {
    return $"Valor = {valor:c2}, Número de Parcelas = {numParcelas}";
  }

}