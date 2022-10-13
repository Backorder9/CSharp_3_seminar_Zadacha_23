/* Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

public class SamplesArray
{
    public static void Main(string[] args)
    {
    Console.Write("Введите целое положительное число больше 1: ");
    int N = int.Parse(Console.ReadLine());
    Console.WriteLine();
    int[] cubes = new int[N];
    for (int i = 0; i < N; i++)
    {
    cubes[i] = Convert.ToInt32(Math.Pow(i+1,3));
    }
    Console.WriteLine($"Кубы чисел от 1 до {N}: " + String.Join(", ", cubes) + ".");
    Console.WriteLine();
    }
}