/*
Напишите программу, которая принимает на вход число N и
выдает произведение чисел от 1 до N.
*/

int GetMulti(int number)
{
    int multi = 1;
    if (number > 0)
    {
        // Перебор всех чисел от 1 до number
        for (int i = 1; i <= number; i++)
        {
            multi = multi * i;
        }
        
    }

    else multi = 0;

    return multi;
}

Console.Write("Imput N: ");
int n = int.Parse(Console.ReadLine());

int multiplication = GetMulti(n);
Console.WriteLine(multiplication);
