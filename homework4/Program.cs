// Задача 25
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// double res = Math.Pow(num1, num2);
// Console.WriteLine($"{num1},{num2} -> {res}");

// Задача 27
// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int k =num; 
// int res = 0;
// while (num>0)
// {
//     res = res + num%10;
//     num = num/10;
// }
// Console.WriteLine($"{k} -> {res}");

// Задача 29
void ArrayFull(int [] array){
    for (int k = 0; k< array.Length; k++)
        array[k] = new Random().Next(1,100);
}
void PrintArray(int[] array){
    Console.WriteLine($"{string.Join(", ", array)} -> [{string.Join(", ", array)}]");
}
int [] array1 = new int[8];
ArrayFull(array1);
PrintArray(array1);