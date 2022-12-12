// Задача 13:Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. Не 
// использовать string[]
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());
if (N > 99 && N < 1000)
{
   Console.WriteLine(N % 10); 
}
else if (N > 999)
{
    while (N > 999)
    {
        N = N / 10;
    }
    Console.WriteLine(N % 10);
}
else if (N < 100)
{
    Console.WriteLine("Третьего числа нет");
}

