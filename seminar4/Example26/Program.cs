/*
Задача 26: Напишите программу, которая принимает на вход число и 
выдает количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

/*
int GetNumers (string stringNumber)
{
    int quantityNum = stringNumber.Length;
    return quantityNum;
}

Console.Write("Imput number: ");
int number = Math.Abs(int.Parse(Console.ReadLine()));
string stringNumber = Convert.ToString(number);

int quantityNum = GetNumers(stringNumber);
Console.Write(quantityNum);
*/

int GetCountDigit(int number)
{
    // Количество цифр в числе
    int countDigit = 0;

    // Временная переменная для хранения входного значения
    int tempNumber = Math.Abs(number);

    // Полсчет цифр в входном числе
    while (tempNumber != 0)
    {
        // Избавление от правой крайней цифры
        tempNumber = tempNumber / 10;

        // Увеличение счетчика на 1
        countDigit++;
    }

    return countDigit;
}

Console.Write("Imput number: ");
int number = int.Parse(Console.ReadLine());

int countDigit = GetCountDigit(number);
Console.Write($"Количество цифр в числе {number}: {countDigit}");
