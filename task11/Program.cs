// Напишите программу, которая выводит
// случайное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
Console.WriteLine($"Случайное число = {num}");
int a = num / 100;
int b = num % 10;

int res = a * 10 + b;

Console.WriteLine($"Результат = {res}");


        
