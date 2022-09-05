// Напишите программу, которая задаёт массив из введенного числа и выводит их на экран.
//пользователь вводит число элементов в массиве и минимальное, и максимальное значение . 
//надо заполнить массив рандоными данными от минимального до максимального значение .И важное уточнениее , 
//делать все в методе который возвращает массив

Console.WriteLine("введите число элементов массива");
int amount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите минимальное значение");
int numberMin = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите ммксимальное значение");
int numberMax = Convert.ToInt32(Console.ReadLine());

int[] array = new int [amount];
for(int i = 0; i < amount; i++)
{
    array[i] = new Random().Next(numberMin, numberMax);
    System.Console.Write(array[i]+ " ");
}

