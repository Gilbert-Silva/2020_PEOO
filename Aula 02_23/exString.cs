using System;
using System.Threading;
using System.Globalization;

class MainClass {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");    string s = "C#";
    Console.WriteLine(s[0]);
    //s[0] = "J";
    DateTime x = DateTime.Parse("23/2/2021");
    //DateTime x = DateTime.Now;
    //DateTime x = new DateTime();
    Console.WriteLine(x);
    Console.WriteLine(x.DayOfWeek);
    Console.WriteLine(x.DayOfYear);
    Console.WriteLine(x.Day);
    Console.WriteLine(x.Month);
    Console.WriteLine(x.Year);
    Console.WriteLine(x.ToString("dd/MM/yy"));
    Console.WriteLine(x.ToString("dd/MMM/yy"));
    Console.WriteLine(x.ToString("dd/MMMM/yy"));
    Console.WriteLine(x.ToString("ddd"));
    Console.WriteLine(x.ToString("dddd"));
    Console.WriteLine(x.ToString("dd/MM/yy hh:mm"));
    
    TimeSpan t = new TimeSpan(6, 1, 0, 0);
    Console.WriteLine(t);

    x = x + t;
    Console.WriteLine(x);

    //int y;
    //Console.WriteLine(y);
    Data d = new Data(23, 02, 2021);
    d.SetMes(03);


  }
}

class Data {
  private int dia, mes, ano;
  public Data(int dia, int mes, int ano) {
    if (mes >= 1 && mes <= 12) this.mes = mes; 
  }
  public void SetMes(int mes) {
    if (mes >= 1 && mes <= 12) this.mes = mes; 
  }
}
