using System;

class MainClass {
  public static void Main() {
    //Animal x = new Animal("");
    Animal a = new Gato("Amarelo");
    Console.WriteLine(a);
    if (a is Gato) {
      // type-casting
      Gato b = a as Gato; 
      Console.WriteLine(b.Mamar());
      Console.WriteLine((a as Gato).Falar());
      Console.WriteLine(((Gato) a).Falar());
    }
    if (a is Cachorro) {
      Console.WriteLine("É um cachorro");
    }
    else
    {
      Console.WriteLine("Não é um cachorro");
      //null.Falar();
      //Console.WriteLine((a as Cachorro).Falar());
      //Console.WriteLine(((Cachorro) a).Falar());
      Console.WriteLine(a as Cachorro);
      //Console.WriteLine((Cachorro) a);
    }
    Console.WriteLine(a.GetType());
    // Console.WriteLine(a.Mamar());
  }
}

class Animal : object {
  private string cor;
  public Animal(string cor) {
    this.cor = cor;
  }
  public override string ToString() {
    return cor;
  }
}
class Mamifero : Animal { 
  public Mamifero(string cor) : base (cor){
  }
  public string Mamar() {
    return "Eu sei mamar";
  }
  public virtual string Falar() {
    return "";
  }
}
class Gato : Mamifero {
  public Gato(string cor) : base (cor){
  }
  public override string Falar() {
    return "Miau";
  }
  public override string ToString() {
    return "Eu sou um gato " + base.ToString();
  }
}
class Cachorro : Mamifero {
  public Cachorro(string cor) : base (cor){
  }
  public override string Falar() {
    return "Au";
  }
}

