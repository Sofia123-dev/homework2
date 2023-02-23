// Задача 10:
// Console.Write("Введите трехзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num / 100 != 0)
//     Console.WriteLine((num / 10) % 10);
// else
//     Console.WriteLine("Это не трехзначное число");

// Задача 13: 
Console.Write("Введите  число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int num2 = num;
int res = 0;

if (num / 100 != 0)
{
     while (num > 0)
    {
        count++;
        num = num / 10;
    }
    for (int k = 0; k < 3; k++)
    {
        count -= 1;
        int tmp = Convert.ToInt32(Math.Pow(10, count));
        res = num2 / tmp;
    }
    Console.WriteLine($"{num2} -> {res % 10}");
}   
else
    Console.WriteLine("Третьей цифры нет");

//Задача 15:
// Console.Write("Введите день недели: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num == 1)
//     Console.WriteLine("Нет");
// else if (num == 2)
//     Console.WriteLine("Нет");
// else if (num == 3)
//     Console.WriteLine("Нет");
// else if (num == 4)
//     Console.WriteLine("Нет");
// else if (num == 5)
//     Console.WriteLine("Нет");
// else if (num == 6)
//     Console.WriteLine("Да");
// else if (num == 7)
//     Console.WriteLine("Да");
// else 
//     Console.WriteLine("Такого дня нет");