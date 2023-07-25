// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] stringArray = {"Asn" , "1111" , "f2f5" , "1a" , "23g" , "2231" , "_" , "Win" , "11321"};

System.Console.WriteLine();

System.Console.WriteLine("Начальный массив:");
int size = 0;
for (int i = 0; i < stringArray.Length; i++) // Определение размера будущего массива
{
    System.Console.Write($"'{stringArray[i]}'\t");
    if (stringArray[i].Length <= 3)
    {
        size++;
    }
}

System.Console.WriteLine();

string[] newStringArray = new string[size];
size = 0;
System.Console.WriteLine("Результат фильтрации:");
for (int i = 0; i < stringArray.Length; i++) // Заполнение нового массива отфильтрованными значениями
{
    if (stringArray[i].Length <= 3)
    {
        newStringArray[size] = stringArray[i];
        Console.Write($"'{newStringArray[size]}'\t");
        size++;
    }
}