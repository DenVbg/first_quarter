// Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше, либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// [hello,2,world,:-)] -> [2, :-)] 
// [1234,1567,-2,computer science] -> [-2]
// [Russia,Denmark,Kazan] -> []


string[] ArrayMin3ElemsInString(string[] array)
{
    int arrLength = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) { arrLength++; }
    }
    string[] arr = new string[arrLength];
    if (arrLength > 0)
    {
        int countElems = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) { arr[countElems] = array[i]; countElems++; }
        }
    }
    return arr;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.WriteLine("Программа, из имеющегося массива строк формирует массив из строк, длина которых меньше, либо равна 3 символа.");
//string[] arrayStrings = {"hello", "2", "world", ":-)"};
//string[] arrayStrings = {"1234", "1567", "-2", "computer science"};
//string[] arrayStrings = {"Russia", "Denmark", "Kazan"};
Console.WriteLine("Введите любые слова или цифры через запятую.");
string? text = Convert.ToString(Console.ReadLine());
while ( text == string.Empty )
{ 
    Console.WriteLine("Вы ничего не ввели. Повторите ввод");
    Console.WriteLine("Введите любые слова, знаки или цифры через пробел.");
    text = Convert.ToString(Console.ReadLine());
}

string[] arrayStrings = text!.Split(',');
Console.WriteLine();
Console.WriteLine("Вы ввели массив из строк");
PrintArray(arrayStrings);

string[] arrayMin3ElemsInString = ArrayMin3ElemsInString(arrayStrings);
Console.WriteLine();
Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символа");
PrintArray(arrayMin3ElemsInString);



