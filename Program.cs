using QuestLib;
using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            QuestFactory factory = null;

            Console.WriteLine("--- КВЕСТ: ЗНАЙТИ ВТРАЧЕНУ РІЧ ---");
            Console.WriteLine();

            Console.WriteLine("Оберіть тип квесту:");
            Console.WriteLine("1 - Міський квест");
            Console.WriteLine("2 - Лісовий квест");
            Console.WriteLine("3 - Домашній квест");

            Console.Write("\nВаш вибір: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    factory = new CityQuestFactory();
                    break;

                case "2":
                    factory = new ForestQuestFactory();
                    break;

                case "3":
                    factory = new HouseQuestFactory();
                    break;

                default:
                    Console.WriteLine("Неправильний вибір");
                    return;
            }

            Quest quest = factory.CreateQuest();
            Location location = factory.CreateLocation();
            Item item = factory.CreateItem();

            Console.WriteLine("\n--- ІНФОРМАЦІЯ ПРО КВЕСТ ---");

            Console.WriteLine("Опис: " + quest.GetDescription());
            Console.WriteLine("Локація: " + location.GetName());
            Console.WriteLine("Загублений предмет: " + item.GetName());

            Console.WriteLine("\n--- ПОЧАТОК КВЕСТУ ---");

            quest.Start();

            Console.WriteLine();
            location.Search();

            Console.WriteLine();
            item.Collect();

            Console.WriteLine("\nКвест завершено");

            Console.ReadKey();
        }
    }
}