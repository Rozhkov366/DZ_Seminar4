/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
натуральную степень B.
3, 5 -> 243 (3?)
2, 4 -> 16*/

Console.Clear();
int Exponentiation(int A, int B)
{
  int result = 1;
  for(int i = 1; i <= B; i++)
  {
    result = result * A;
  }
  return result;
}
Console.Write("Введите число A: ");
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int NumberB = Convert.ToInt32(Console.ReadLine());
int exponentiation = Exponentiation(NumberA, NumberB);
Console.WriteLine("Ответ: " + exponentiation);