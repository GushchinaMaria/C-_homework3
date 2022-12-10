/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Введите коордитаты точки А1: ");
int A1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коордитаты точки А2: ");
int A2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коордитаты точки А3: ");
int A3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коордитаты точки B1: ");
int B1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коордитаты точки B2: ");
int B2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите коордитаты точки B3: ");
int B3 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt (Math.Pow(A1-B1,2) + (Math.Pow(A2-B2,2) + Math.Pow(A3-B3,2)));

Console.WriteLine($"Расстояние между двумя точками равно {result}");