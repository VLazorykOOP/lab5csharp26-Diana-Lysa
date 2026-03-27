using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5CSharp
{
    public record AbiturientRecord(string FullName, int BirthYear, int[] Grades, double AvgScore);

    public static class Task4
    {
        public static void RunInteractiveVariant()
        {

            var students = new List<AbiturientRecord> {
                new ("Іваненко І.І.", 2005, new[] {170, 180, 175}, 10.5),
                new ("Петренко П.П.", 2006, new[] {160, 150, 165}, 9.2),
                new ("Сидорчук А.В.", 2005, new[] {190, 195, 200}, 11.8),
                new ("Коваленко О.М.", 2007, new[] {180, 170, 190}, 10.1)
            };

            Console.WriteLine("\n  ПОЧАТКОВИЙ СПИСОК АБІТУРІЄНТІВ ");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].FullName} (Сер. бал: {students[i].AvgScore})");
            }

            // 2. ІНТЕРАКТИВНЕ ВИДАЛЕННЯ
            Console.Write("\nВведіть НОМЕР абітурієнта для ВИДАЛЕННЯ: ");
            if (int.TryParse(Console.ReadLine(), out int numToRemove))
            {
                int index = numToRemove - 1;
                if (index >= 0 && index < students.Count)
                {
                    Console.WriteLine($" Видаляємо: {students[index].FullName}");
                    students.RemoveAt(index);
                }
            }

            // 3. ІНТЕРАКТИВНЕ ДОДАВАННЯ
            Console.Write("\nПісля якого прізвища додати нового?: ");
            string searchName = Console.ReadLine();

            // Шукаємо індекс
            int foundIdx = students.FindIndex(s => s.FullName.Contains(searchName, StringComparison.OrdinalIgnoreCase));

            if (foundIdx != -1)
            {
                Console.WriteLine($" Знайдено: {students[foundIdx].FullName} ");

                Console.Write("Введіть ПІБ того, кого ми додаємо: ");
                string newFullName = Console.ReadLine();

                Console.Write("Введіть середній бал для нього: ");
                if (!double.TryParse(Console.ReadLine(), out double newScore)) newScore = 0.0;

                var newStudent = new AbiturientRecord(newFullName, 2006, new[] { 10, 10, 10 }, newScore);
                students.Insert(foundIdx + 1, newStudent);

                Console.WriteLine($"Успішно додано {newFullName} після {students[foundIdx].FullName}!");
            }
            else
            {
                Console.WriteLine("Такого прізвища не знайдено, нікого не додаємо.");
            }

            Console.WriteLine("\n ОНОВЛЕНИЙ СПИСОК ");
            foreach (var s in students) Console.WriteLine($"- {s.FullName}, Бал: {s.AvgScore}");
        }
    }
}
