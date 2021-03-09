using System;

class MainClass {
  public static void Main() {
    Compromisso a = new Compromisso();
    a.Assunto = "Aula de PEOO";
    a.Local = "Meet";
    a.Data = DateTime.Parse("2021/03/16 14:00");

    Compromisso b = new Compromisso {
      Assunto = "Questionário de Interfaces",
      Local = "GSA",
      Data = DateTime.Parse("2021/03/15 23:59")
    }; 

    Compromisso c = new Compromisso {
      Assunto = "Questionário de Interfaces II",
      Local = "GSA",
      Data = DateTime.Parse("2021/03/22 23:59")
    };

    //Console.WriteLine(a);
    //Console.WriteLine(b);

    Agenda x = new Agenda();
    Console.WriteLine(x.K);
    x.Inserir(a);
    Console.WriteLine(x.K);
    x.Inserir(b);
    Console.WriteLine(x.K);
    x.Inserir(c);
    Console.WriteLine(x.K);
    foreach(Compromisso w in x.Listar())
      Console.WriteLine(w);
  }
}

class Agenda {
  private Compromisso[] comps = new Compromisso[1];
  private int k;
  public int Qtd { get => k; }
  public int K { get => comps.Length; }
  public void Inserir(Compromisso c) {
    if (k == comps.Length) 
      Array.Resize(ref comps, 2*comps.Length);
    comps[k++] = c;
  }
  public Compromisso[] Listar() {
    Compromisso[] r = new Compromisso[k];
    Array.Copy(comps, r, k);
    return r;
  }
}

class Compromisso {
  public string Assunto { get; set; }
  public string Local { get; set; }
  public DateTime Data { get; set; }
  public override string ToString() {
    return $"{Data:dd/MM/yyyy HH:mm} - {Assunto} - {Local}";
  }

}