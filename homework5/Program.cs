// Задание 34
// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(99, 1000);
//     }
// }
// string ChangeArray(int[] array)
// {
//     string result = "В массиве нет четных элементов!";
//     int count = 0;
//     foreach (var el in array) if (el % 2 == 0) count++;
//     if (count != 0) result = $"[{string.Join(", ", array)}] -> {count}";
//     return result;
// }
// int[] array1 = new int[5];
// FillArray(array1);
// Console.WriteLine(ChangeArray(array1));

// Задание 36
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);
// int sum = 0;

// for (int z = 0; z < numbers.Length; z+=2)
//     sum = sum + numbers[z];

//     Console.Write($" -> {sum}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
// void PrintArray(int[] numbers)
// {
//     Console.Write("[ ");
//     for(int i = 0; i < numbers.Length; i++)
//         {
//             Console.Write(numbers[i] + " ");
//         }
//     Console.Write("]");
// }

// Задача 38
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
int max = numbers[0];
int min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }

}
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
    
}
Console.Write($"[{string.Join(", ", numbers)}]-> {max - min}");