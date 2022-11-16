//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
void Task34(int size)
{
    //объявляем массив размера size
    int[] RandomArray = new int[size];
    //генерация элементов массива
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(100,1000);
    }
    //проверка количества чётных чисел и вывод элементов сгенерированного массива
    int Count = 0; //переменная-счётчик в которой запоминает
    Console.WriteLine("Cгенерированный массив");
    for (int i = 0; i < RandomArray.Length; i++)
    {
        Console.WriteLine(Convert.ToString(RandomArray[i]));
        if (RandomArray[i] % 2 == 0)
        {
            Count = Count + 1;
        }
    }
    Console.WriteLine("В данном массиве четных чисел - " + Count + "");

}
//ввод пользователем размера массива 
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Task34(size);
*/

//Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
void Task36(int size)
{
    //объявляем массив размера size
    int[] RandomArray = new int[size];
    int summa = 0;//переменная, которая хранит сумму элементов, стоящих на нечётных позициях
    //генерация элементов массива
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(1, 100);
        Console.WriteLine(RandomArray[i]);//вывод элемента массива
    }
    //цикл по элементам, стоящим на нечётных позициях
    for (int i = 1; i < RandomArray.Length; i += 2)
    {
        summa += RandomArray[i];
    }
    Console.WriteLine("Cумма всех элементов, стоящих на нечётных позициях равна "+summa);
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Task36(size);
*/
/*
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void Task38(int size)
{
    //объявляем массив размера size
    int[] RandomArray = new int[size];

    //генерация элементов массива
    for (int i = 0; i < size; i++)
    {
        RandomArray[i] = new Random().Next(1, 100);
        Console.WriteLine(RandomArray[i]);//вывод элемента массива
    }
    int min = RandomArray[0];//переменная, которая хранит значение минимума. Зададим ей значение 0-го элемента сгенерированного массива.
    int max = RandomArray[0];//переменная, которая хранит значение максимума. Зададим ей значение 0-го элемента сгенерированного массива.
    for(int i = 0; i < size; i++)
    {
        if (RandomArray[i] < min) 
            min = RandomArray[i];
        if (RandomArray[i] > max) 
            max = RandomArray[i];
    }
    int r = max - min;
    Console.WriteLine("Разница между максимальным и минимальным элементом массива - " + r);
}
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
Task38(size);
*/