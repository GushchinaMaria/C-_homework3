/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */



Console.WriteLine("ВВедите число: ");
string enternum = Console.ReadLine();
int N = Convert.ToInt32(enternum);

Console.WriteLine($"Кубы чисел от 1 до {N}:");

for (int i=1; i<=N; i++)
{

    Console.Write(i*i*i+",");

}

