/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

// Методы массивов
//Вывод массива в консоль
void PrintArray(string[] _array)
{
    Console.Write("[ ");
    foreach (var item in _array)
        Console.Write($"{item} ");
    Console.Write("]");
}

//Функциb для задачи
//Возвращает значение количества строк указанной длинны int.

int FindCountStringWithLen(string[] _array, int _lenStr = 3)
{
    int count = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i].Length < _lenStr + 1) count++;
    }
    return count;
}

//Формирует и возвращает новый массив на основе заданного в котором будут только строки указанной длинны и меньше.

string[] NewArray(string[] _array, int _count, int _lenStr = 3)
{
    string[] _arrayNew = new string[_count];
    int count = 0;
    for (int i = 0; i < _array.Length; i++)
    {
        if (_array[i].Length < _lenStr + 1)
        {
            _arrayNew[count] = _array[i];
            count++;
        }
    }
    return _arrayNew;
}

//Основной код


string[] array = { "dom", "vodka", "balalaika", "kot" };
Console.WriteLine("Базовый массив:");
PrintArray(array);

int count = FindCountStringWithLen(array, 3);

string[] arrayNew = NewArray(array, count, 3);
Console.WriteLine();

Console.WriteLine("Новый массив:");
PrintArray(arrayNew);
Console.WriteLine();


