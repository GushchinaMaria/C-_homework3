/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */

Console.WriteLine("Введите пятизначное положительное натуральное число: ");
string enternum = Console.ReadLine();
int numb = Convert.ToInt32(enternum);
int lenght_of_numb = enternum.Length;
bool Mark = true;

if (lenght_of_numb != 5 ) Console.WriteLine("Вы ввели не пятизначное число");
else
{
    for  (int i =0; (i < lenght_of_numb/2) && (Mark == true); i++)    
    {   
        if (String.Equals(enternum[i],enternum[lenght_of_numb-i-1]))                        
    {
        Mark=true;
     
    }    
    else
     Mark = false;
    } 
   
}

 if (Mark == true) Console.WriteLine("Палиндром");
    else
    {
        Console.WriteLine("Не палиндром");
    }