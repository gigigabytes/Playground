using System;

class Program {
  public static void Main() {
    Console.WriteLine("Bem-vindo ao Playground");
    Responsavel r1 = new Especie(1, "Pai");
    Responsavel r2 = new Especie(2, "Mãe");
    Crianca c1 = new Crianca(1, "Crianca1", "Sexo1", DateTime.Parse("01/01/2015"), 1;
    Crianca c2 = new Crianca(2, "Crianca2", "Sexo1", DateTime.Parse("01/01/2016"), 1;

    Console.WriteLine(r1);
    Console.WriteLine(r2);
    Console.WriteLine(c1);
    Console.WriteLine(c2);
  }
}