// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//  Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// try
// {
//     Console.Write("Введите число: ");
//     string num = Console.ReadLine();
//     int len = num.Length;

//     if (len == 5)
//     {
//         if (num[0] == num[4] && num[1] == num[3])
//         {
//             Console.Write("да");
//         }
//         else
//         {
//             Console.Write("нет");
//         }
//     }
//     else
//     {   
//         Console.WriteLine("не пятизначное число");
//     }
// }
// catch
// {
//     Console.WriteLine("Были введены некорректные данные");
// }
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Console.WriteLine("Введите начение X1");
// int X1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начение Y1");
// int Y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начение Z1");
// int Z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начение X2");
// int X2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начение Y2");
// int Y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите начение Z2");
// int Z2 = Convert.ToInt32(Console.ReadLine());
// double res = Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)+ Math.Pow(Z2 - Z1, 2));
// Console.WriteLine(Math.Round(res, 2));
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
string res = String.Empty;
int k = 0;
while (k<num)
{
    k++;
    res += $"{Math.Pow(k, 3)}, ";
}
Console.WriteLine($"{num} -> {res}");