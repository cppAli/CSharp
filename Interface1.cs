using System;
using System.Collections.Generic;
using System.Linq;

interface IAnimal
{
    void MakeSound();
    string GetInfo();
}

abstract class Animal : IAnimal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public abstract void MakeSound();
    public abstract string GetInfo();
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Мяв!");
    }

    public override string GetInfo()
    {
        return $"Кот - ID: {Id}, Имя: {Name}, Возрат: {Age}";
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Гав!");
    }

    public override string GetInfo()
    {
        return $"Собака - ID: {Id}, Имя: {Name}, Возрат: {Age}";
    }
}

class Bird : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Цвинь");
    }

    public override string GetInfo()
    {
        return $"Птица - ID: {Id}, Имя: {Name}, Возрат: {Age}";
    }
}

class Reptile : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Аррр");
    }

    public override string GetInfo()
    {
        return $"Рептилия - ID: {Id}, Имя: {Name}, Возрат: {Age}";
    }
}

class AnimalShelter
{
    private List<Animal> animals;

    public List<Animal> Animals
    {
        get { return animals; }
    }

    public AnimalShelter()
    {
        animals = new List<Animal>();
    }

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void RemoveAnimal(Animal animal)
    {
        animals.Remove(animal);
    }

    public void PrintAnimals()
    {
        if (animals.Count == 0)
        {
            Console.WriteLine("Животных в приюте нет.");
        }
        else
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.GetInfo());
                
            }
        }
    }
}


