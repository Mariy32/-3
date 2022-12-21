// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да




void Num(string number)
{
  if (number[0]==number[4] || number[1]==number[3])
  {
    Console.WriteLine($"Число: {number}  является палиндром.");
  }
  else Console.WriteLine($"Число: {number} - не является палиндром.");
}

Console.WriteLine ("Введите пятизначное число");
string? number = Console.ReadLine();
// string N = Convert.ToInt32(Console.ReadLine());
Num (number);





// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double N(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//  double k1 = x1 - x2;
//  double k2 = y1 - y2;
//  double k3 = z1 - z2;
//  double g = Math.Sqrt(k1*k1 + k2*k2 + k3*k3);

// return g;
// }

// Console.WriteLine("Введите x1:");
// double x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y1:");
// double y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z1:");
// double z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите x2:");
// double x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите y2:");
// double y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите z2:");
// double z2 = Convert.ToInt32(Console.ReadLine());
// double result = N(x1, y1, z1, x2, y2, z2);
// Console.WriteLine(result);





// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void kub(int N)
// {
// for (int i = 1; i <= N; i++)
// {
//      Console.WriteLine(i*i*i);
// } 
// }

// Console.WriteLine("Введите число");
// int Num = Convert.ToInt32(Console.ReadLine());
// kub(Num);