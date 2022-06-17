/*Написать программу,которая из имеющегося массива строк формирует массив из строк,длина которых меньше либо
равна 3 символа.Первоначальный массив можно ввести с клавиатуры,либо задать на старте выполнения алгоритма.*/

Console.WriteLine("Введите количество используемых строк: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] arrayOriginal = new string[size];
string[] arrayAnswer=new string[size];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
    Console.WriteLine();
}
