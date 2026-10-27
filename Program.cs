```csharp
using System;
using System.Collections.Generic;

public class Animal
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Animal(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal está emitindo um som.");
    }
}

public class Cachorro : Animal
{
    public Cachorro(string nome, int idade) : base(nome, idade)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro está latindo: Au au!");
    }
}

public class Gato : Animal
{
    public Gato(string nome, int idade) : base(nome, idade)
    {
    }

    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando: Miau!");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("=== SISTEMA DE ANIMAIS ===");
        Console.WriteLine();

        Cachorro rex = new Cachorro("Rex", 3);
        Gato mimi = new Gato("Mimi", 2);

        List<Animal> animais = new List<Animal>();

        animais.Add(rex);
        animais.Add(mimi);

        foreach (Animal animal in animais)
        {
            Console.WriteLine($"Animal: {animal.Nome}");
            Console.WriteLine($"Idade: {animal.Idade} anos");
            Console.Write("Som: ");

            animal.EmitirSom();

            Console.WriteLine();
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}
```