/*
Задача 13: Напишите программу, 
которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/* 1 Ваиант

Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length > 2)
{
  Console.WriteLine("третья цифра -> " + numberText[2]);
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}
*/

// 2 вариант

Console.Write("Введи число: ");
int digit = Convert.ToInt32(Console.ReadLine());
string str = digit +"" ;

char[] massiv = str.ToCharArray();

if(massiv.Length ==0)
{
    Console.Write("Тртья цифра");
}
else
{
    Console.Write(massiv[2]);
    
}



