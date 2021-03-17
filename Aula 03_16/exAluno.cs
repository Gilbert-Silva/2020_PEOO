using System;
using System.Collections;

class MainClass {
  public static void Main() {
    Aluno a = new Aluno("Leonardo", DateTime.Parse("2000-01-01"), 170);
    Aluno b = new Aluno("Gilbert", DateTime.Parse("2001-01-01"), 175);
    Aluno c = new Aluno("Eduardo", DateTime.Parse("1999-01-01"), 172);
    //Console.WriteLine(a);
    //Console.WriteLine(b);
    //Console.WriteLine(c);
    Aluno[] v = { a, b, c };

    string[] w = { "Java", "Potigol", "C#" };
    Vetor.Ordenar(w);
    foreach(string s in w)
      Console.WriteLine(s);
 
    Console.WriteLine(a.CompareTo(b));

    //Vetor.Ordenar(v);
    //Array.Sort(v); // Nome
    //Array.Sort(v, new CompAlunos()); // Altura
     
    CompAlunosNasc ord = new CompAlunosNasc(); 
    Array.Sort(v, ord); // Nascimento

    foreach(Aluno x in v)
      Console.WriteLine(x);
  }
}

class Vetor {
  public static void Ordenar(IComparable[] v) {
    for(int i = 0; i < v.Length - 1; i++)
      for(int j = i + 1; j < v.Length; j++)
        //if (v[i].Nome.CompareTo(v[j].Nome) > 0) {
        if (v[i].CompareTo(v[j]) > 0) {
          IComparable aux = v[i];
          v[i] = v[j];
          v[j] = aux;
        }
  }
  public static void Ordenar(IComparable[] v, IComparer obj) {
    for(int i = 0; i < v.Length - 1; i++)
      for(int j = i + 1; j < v.Length; j++)
        //if (v[i].Nome.CompareTo(v[j].Nome) > 0) {
        if (obj.Compare(v[i], v[j]) > 0) {
          IComparable aux = v[i];
          v[i] = v[j];
          v[j] = aux;
        }
  }
}

class CompAlunos : IComparer {
  public int Compare (object x, object y) {
    Aluno a = (Aluno) x;
    Aluno b = (Aluno) y;
    //return a.Altura.CompareTo(b.Altura);
    if (a.Altura == b.Altura) return 0;
    else
      if (a.Altura > b.Altura) return 1;
      else return -1;
  }
}

class CompAlunosNasc : IComparer {
  public int Compare (object x, object y) {
    Aluno a = (Aluno) x;
    Aluno b = (Aluno) y;
    return a.Nasc.CompareTo(b.Nasc);
  }
}

class Aluno : IComparable {
  private string nome;
  private DateTime nasc;
  private int alt;
  public string Nome { get => nome; }
  public int Altura { get => alt; }
  public DateTime Nasc { get => nasc; }
  public Aluno(string nome, DateTime nasc, int alt) {
    this.nome = nome;
    this.nasc = nasc;
    this.alt = alt;
  }
  public int CompareTo(object obj) {
    Aluno x = (Aluno) obj; // cast
    return this.Nome.CompareTo(x.Nome);
  }
  public override string ToString() {
    return $"{nome} {nasc:dd/MM/yyy} {alt}";
  }
}