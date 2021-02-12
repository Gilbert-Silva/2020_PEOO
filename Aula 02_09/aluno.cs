using System;

class MainClass {
  public static void Main() {
    Console.WriteLine(Aluno.GetQtd());
    Aluno a1 = new Aluno();
    Console.WriteLine(Aluno.GetQtd());
    Aluno a2 = new Aluno();
    Console.WriteLine(Aluno.GetQtd());
    a1.SetNome("Gilbert");
    a1.SetIdade(48);
    a2.SetNome("Leonardo");
    Console.WriteLine(a1.GetNome());
    Console.WriteLine(a1.GetMatricula());
    Console.WriteLine(a1.GetIdade());
    Console.WriteLine(a2.GetNome());
    Console.WriteLine(a2.GetMatricula());
    Console.WriteLine(a2.GetIdade());

    a1 = a2;
    a1.SetNome("Eduardo");
    a2.SetNome("Eduardo");

    Console.WriteLine(a1.GetNome());
    Console.WriteLine(a2.GetNome());

    Console.WriteLine(a1.GetContador());
    Console.WriteLine(a2.GetContador());
  }
}

class Aluno {
  private static int qtd; 
  public static int GetQtd() { 
    return qtd;
  }
  public Aluno() {
    qtd++;
  }
  private string nome;
  private string matricula;
  private int idade;
  public void SetNome(string n) {
    if (n.Length >= 3) nome = n;
  }
  public void SetMatricula(string m) {
    if (m.Length >= 3) matricula = m;
  }
  public void SetIdade(int i) {
    if (i >= 0) idade = i;
  }
  public string GetNome() {
    return nome;
  }
  public string GetMatricula() {
    return matricula;
  }
  public int GetIdade() {
    return idade;
  }
  public int GetContador() {
    return qtd;
  }
}