// Текст задачи: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Clear();
// ПРИМЕРЫ:
// "hello", "2", "world", ":-)" -> ["2", ":-)"]
// "1234", "1567", "-2", "computer science" -> ["-2"]
// "Russia", "Denmark", "Kazan" -> []
string[] array = { "hello", "2", "world", ":-)" };
string[] arraynew = new string[array.Length];

//Console.WriteLine("Первоначальный массив строк: "); 
//Console.WriteLine("[" string.Join(", ", array) + "]");

void ArrayIf(string[] array, string[] arraynew)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arraynew[count] = array[i];
            count++;
        }
    }
}


//Console.WriteLine("Обработанный массив строк: ");
//Console.WriteLine("[" string.Join(", ", arraynew)) + "]"); 

