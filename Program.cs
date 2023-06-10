//Разработайте систему для управления животным приютом. 
//В вашем приюте могут находиться различные виды животных, такие как кошки, собаки, птицы и рептилии. 
//Каждое животное имеет уникальный идентификатор, кличку и возраст.

//Требования:

//Создайте интерфейс IAnimal, который содержит следующие методы:

//void MakeSound(), который будет выводить звук, издаваемый животным.
//string GetInfo(), который будет возвращать информацию о животном в виде строки.
//Создайте абстрактный класс Animal, реализующий интерфейс IAnimal. 
//В этом классе определите следующие общие свойства:

//Уникальный идентификатор животного.
//Кличку животного.
//Возраст животного.
//Создайте классы Cat, Dog, Bird и Reptile, наследующиеся от класса Animal. 
//Каждый из этих классов должен реализовывать методы интерфейса IAnimal в соответствии с особенностями соответствующего вида животного.

//Создайте класс AnimalShelter, который будет содержать список животных в приюте. Реализуйте следующие методы:

//void AddAnimal(Animal animal), для добавления животного в приют.
//void RemoveAnimal(Animal animal), для удаления животного из приюта.
//void PrintAnimals(), для вывода информации о всех животных в приюте.
//Создайте программу, которая демонстрирует работу вашей системы управления животным приютом. 
//Программа должна содержать меню с возможностью добавления и удаления животных, а также просмотра информации о животных.

class Program
{
    static void Main(string[] args)
    {
        AnimalShelter shelter = new AnimalShelter();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Система управления приютом для животных");
            Console.WriteLine("1. Добавить животное");
            Console.WriteLine("2. Удалить животное");
            Console.WriteLine("3. Показать данные");
            Console.WriteLine("4. Выход");
            Console.Write("Введите свой выбор: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddAnimal(shelter);
                    break;
                case 2:
                    RemoveAnimal(shelter);
                    break;
                case 3:
                    shelter.PrintAnimals();
                    break;
                case 4:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте еще раз.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static int animalIdCounter = 1;

    static void AddAnimal(AnimalShelter shelter)
    {
        Console.WriteLine("Добавить животное");
        Console.WriteLine("1. Кошка");
        Console.WriteLine("2. Собака");
        Console.WriteLine("3. Птица");
        Console.WriteLine("4. Рептилия");
        Console.Write("Введите свой выбор: ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Ввод Имени: ");
        string name = Console.ReadLine();
        Console.Write("Ввод Возраст: ");
        int age = int.Parse(Console.ReadLine());

        Animal animal;
        switch (type)
        {
            case 1:
                animal = new Cat();
                break;
            case 2:
                animal = new Dog();
                break;
            case 3:
                animal = new Bird();
                break;
            case 4:
                animal = new Reptile();
                break;
            default:
                Console.WriteLine("Недопустимый тип животного.");
                return;
        }

        animal.Id = animalIdCounter; // Устанавливаем уникальный ID для животного
        animalIdCounter++; // Увеличиваем счетчик ID

        animal.Name = name;
        animal.Age = age;

        shelter.AddAnimal(animal);
        animal.MakeSound();
        Console.WriteLine("Животное добавлено в приют.");
    }


    static void RemoveAnimal(AnimalShelter shelter)
    {
        Console.WriteLine("Удалить животное");
        Console.Write("Введите ID животного, которое нужно удалить: ");
        int id = int.Parse(Console.ReadLine());

        Animal animalToRemove = shelter.Animals.FirstOrDefault(animal => animal.Id == id);
        if (animalToRemove != null)
        {
            shelter.RemoveAnimal(animalToRemove);
            Console.WriteLine("Животное изъяли из приюта.");
        }
        else
        {
            Console.WriteLine("Животное не найдено в приюте.");
        }
    }


}