// Текст задачи: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
void ArrayIf(string[] array, string[] arraynew) // Перещелкиваем весь массив, сравнивая каждое значение по его длине.
{
    int count = 0; // "Count" - счетчик для второго массива.
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arraynew[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array) // Распечатка массива в терминал
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// ПРИМЕРЫ:
// "hello", "2", "world", ":-)" -> ["2", ":-)"]
// "1234", "1567", "-2", "computer science" -> ["-2"]
// "Russia", "Denmark", "Kazan" -> []
string[] array = { "hello", "2", "world", ":-)" }; // Рисуем первый массив
string[] arraynew = new string[array.Length]; // Создаем второй массив, контейнер после обработки первого
Console.WriteLine("Первоначальный массив строк: ");
PrintArray(array);
ArrayIf(array, arraynew);
Console.WriteLine("Обработанный массив строк (значения не более трех символов): ");
PrintArray(arraynew);