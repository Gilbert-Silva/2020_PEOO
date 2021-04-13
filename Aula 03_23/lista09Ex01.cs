using System;

class MainClass {
  public static void Main() {
    DisciplinaSemestral a = new DisciplinaSemestral(
      "Filosofia I", 100, 100, 0);
    DisciplinaAnual b = new DisciplinaAnual("PEOO",
      80, 80, 100, 75, 0);  
    Console.WriteLine($"{a.GetNome()} --- {a.CalcMediaFinal()}");  
    Console.WriteLine($"{b.GetNome()} --- {b.CalcMediaFinal()}");
    Console.WriteLine($"{a.GetNota1()}");  

    IDisciplina[] x = new IDisciplina[2];
    x[0] = new DisciplinaSemestral("Filosofia I", 100, 100, 0);
    x[1] = new DisciplinaAnual("PEOO", 80, 80, 100, 75, 0);  
    //Console.WriteLine($"{x[0].GetNota1()}");  
    foreach(IDisciplina d in x)
      Console.WriteLine($"{d.GetNome()} --- {d.CalcMediaFinal()}");

    object[] w = new object[2];
    w[0] = new DisciplinaSemestral("Filosofia I", 100, 100, 0);
    w[1] = new DisciplinaAnual("PEOO", 80, 80, 100, 75, 0);  
    //Console.WriteLine($"{x[0].GetNota1()}");  
    foreach(object o in w)
      Console.WriteLine($"{o.ToString()}");

  }
}

interface IDisciplina {
  string GetNome();
  int CalcMediaFinal();
}

class DisciplinaSemestral : IDisciplina {
  private string nome;
  private int nota1;
  private int nota2;
  private int notaFinal;
  public DisciplinaSemestral(string nome, int n1, int n2, int nf) {
    this.nome = nome;
    nota1 = n1;
    nota2 = n2;
    notaFinal = nf;
  }
  public int GetNota1() { return nota1; }
  public string GetNome() { return nome; }
  public int CalcMediaFinal() { 
    int m = (2 * nota1 + 3 * nota2) / 5;
    if (m < 60) m = (m + notaFinal) / 2;
    return m;
  }
}

class DisciplinaAnual : IDisciplina {
  private string nome;
  private int nota1;
  private int nota2;
  private int nota3;
  private int nota4;
  private int notaFinal;
  public DisciplinaAnual(string nome, int n1, int n2, int n3, int n4, int nf) {
    this.nome = nome;
    nota1 = n1;
    nota2 = n2;
    nota3 = n3;
    nota4 = n4;
    notaFinal = nf;
  }
  public int GetNota1() { return nota1; }
  public string GetNome() { return nome; }
  public int CalcMediaFinal() { 
    int m = (2*nota1 + 2*nota2 + 3*nota3 + 3*nota4) / 10;
    if (m < 60) m = (m + notaFinal) / 2;
    return m;
  }
}