/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 */

Console.WriteLine("Enter number a:");
string numberStrA = Console.ReadLine() ?? "";
Console.WriteLine("Enter number b:");
string numberStrB = Console.ReadLine() ?? "";

if(int.TryParse(numberStrA, out int numberA) && int.TryParse(numberStrB, out int numberB)){
  if(numberA > numberB){
    Console.WriteLine($"max = {numberA}");
  }else{
    Console.WriteLine($"max = {numberB}");
  }
}else{
  Console.WriteLine($"invalid input");
}