//Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

Random threeDigitNumber = new Random();
int number = threeDigitNumber.Next( 10 , 1000);
Console.WriteLine("Three digit number -> " + number);
Console.WriteLine("The second digit of a three-digit number -> " + number / 10 % 10);