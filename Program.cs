// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int Show2ndDigit(int number)
{
    int sot = number / 10;
    int dec = sot % 10;

    int result = dec;
    return result;
}

Console.Write("Input 3-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int numAbs = System.Math.Abs(num);

int newNum = Show2ndDigit(numAbs);
Console.WriteLine($"Second digit of {num} is {newNum}.");
*/


// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа.
/*
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int numAbs = System.Math.Abs(num);

int Show3rdDigit(int number)
    {
        int result = -1;
        if (numAbs >= 100)
        {
            while (numAbs > 999)
            {
                numAbs = numAbs / 10;
            }
            result = numAbs % 10;
        }
        return result;
    }

int newNum = Show3rdDigit(numAbs);
Console.WriteLine($"Third digit of {num} is {newNum}.");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день 
// выходным.
/*
bool IsHolyday(int number)
{
    bool result = false;

    if(number == 6 || number == 7)
    {
        result = true;
    }

    return result;
}

Console.Write("Input number of the day of the week: ");
int num = Convert.ToInt32(Console.ReadLine());

bool result = IsHolyday(num);
Console.WriteLine(result);
*/

