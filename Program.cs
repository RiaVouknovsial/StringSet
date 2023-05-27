//Задача 1. Реализуйте класс "StringSet", представляющий множество строк. 
//Перегрузите операторы объединения (+) и пересечения(&) для множеств строк. 
//Создайте два объекта типа "StringSet" и выполните операции объединения и пересечения между ними.

using System;

Console.WriteLine("Массив строк: ");

StringSet s1 = new StringSet { Value = "January, February, March, April, May, June, " };
StringSet s2 = new StringSet { Value = "July, August, September, October, November, December" };

Console.WriteLine(s1.Value);
Console.WriteLine(s2.Value);
Console.WriteLine();

Console.WriteLine("Конкатенация строк: ");
StringSet s3 = s1 + s2;
Console.WriteLine(s3.Value);
Console.WriteLine();

Console.WriteLine("Пересечение строк: ");
StringSet s4 = s1 & s2;
Console.WriteLine(s3.Value); 


