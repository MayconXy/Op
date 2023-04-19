using System;
using System.Collections.Generic;

class MiniZoo 
{
    private List<Animal> animais = new List<Animal>();

    public void AdicionarAnimal(Animal animal) 
    {
        animais.Add(animal);
    }

    public void ListarAnimais() 
    {
        foreach (Animal animal in animais) 
        {
            Console.WriteLine($"Nome: {animal.Nome} | Idade: {animal.Idade}");
        }
    }
}

class Program 
{
    static void Main(string[] args) 
    {
        Animal Leão = new Animal { Nome = "Leão", Idade = 3 };
        Animal cobra = new Animal { Nome = "Cobra", Idade = 2 };

        MiniZoo zoo = new MiniZoo();
        zoo.AdicionarAnimal(Leão);
        zoo.AdicionarAnimal(Cobra);
        zoo.ListarAnimais();
    }
}