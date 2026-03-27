using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using Lab5CSharp;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("МЕНЮ ЛАБОРАТОРНОЇ РОБОТИ №5");
            Console.WriteLine("1. Завдання 1-2: Транспорт ");
            Console.WriteLine("2. Завдання 3: Фігури ");
            Console.WriteLine("3. Завдання 4: Відеокасети ");
            Console.WriteLine("0. Вихід");
            Console.Write("\nВаш вибір: ");

            string input = Console.ReadLine();
            if (input == "0") break;

            switch (input)
            {
                case "1":
                    Console.WriteLine("\n ВИКОНАННЯ ЗАВДАННЯ 1-2 ");
                    Express myExp = new Express("Інтерсіті+", 9, "Київ-Львів");
                    myExp.Show();

                    Car myCar = new Car("Tesla", "Електро");
                    myCar.Show();

                    Console.WriteLine("\nДемонстрація конструктора копіювання:");
                    Express copyExp = new Express(myExp);
                    copyExp.Show();

                    myExp = null;
                    copyExp = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    break;

                case "2":
                    Console.WriteLine("\n ВИКОНАННЯ ЗАВДАННЯ 3 (Фігури) ");
                    Figure[] figures = {
                        new Circle(10),
                        new Rectangle(4, 6),
                        new Triangle(3, 4, 5)
                    };

                    Console.WriteLine("Результати обчислень:");
                    foreach (var f in figures)
                    {
                        f.Show();
                    }
                    break;

                case "3":
                    Lab5CSharp.Task4.RunInteractiveVariant();
                    break;

                default:
                    Console.WriteLine("Помилка! Оберіть пункт від 0 до 3.");
                    break;
            }
        }
    }
}