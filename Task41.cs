// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
public class Task41
{
    public static void NumbersMoreThanNull()
    {
        Console.WriteLine("Input Numbers with space");
        string? input = Console.ReadLine();
        string[] arrayOfParts = input.Split(' ');
        int countMoreNull = 0;
        for (int i = 0; i < arrayOfParts.Length; i++)
        {
            double number = Convert.ToInt32(arrayOfParts[i]);
            if (number > 0) countMoreNull++;
            //Console.WriteLine(number);
        }
        Console.WriteLine("Numbers more Null  : " + countMoreNull);
    }
}