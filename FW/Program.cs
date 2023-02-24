// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.
// Первоначальный масиив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array1 = new string[7] {"541642", "11", "Привет", "Дуб", "090", "51", "63212"};
string[] array2 = new string[array1.Length];
void ArrayReduction(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayReduction(array1, array2);
PrintArray(array2);