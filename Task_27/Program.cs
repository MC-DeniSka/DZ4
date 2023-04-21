// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumLen(int num)
{
    int length;
    if(num > 0)
    {
        for (length = 0; num > 0; length++)
         {
              num = num / 10;
         } 
        return length;
    }
    return -1;
}

int SumNumbers (int num, int len)
{
    int sum = 0;
    for (int i = 0; i < len; i++)
    {
        sum = sum + (num % 10);
        num = num/10;
    }
    return sum;
}

void PrintResult(int num, int sum)
{
    if(num > 0)
    {
        System.Console.WriteLine(sum);
       
    }
    else
    {
       System.Console.WriteLine("Ошибка! Введите положительное число");
    }
}


int number = ReadInt("Введите целое число ");
int numLen = NumLen(number);
int summa = SumNumbers(num: number, len: numLen);
PrintResult(number,summa);