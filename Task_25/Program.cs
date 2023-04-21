// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Exponentiation(int num1, int num2)
{
    int result = 1;
    if (num2 > 0 )
    {
         for (int i = 0; i < num2; i++)
        {
            result = result * num1;
        }
    }
    else
    {
        System.Console.WriteLine("Ошибка! Степень должна быть положительной!");
        return -1;
    }
    
    return result;
}


int numberA = ReadInt("Введите число ");
int numberB = ReadInt("Введите степень ");
int result = Exponentiation(num1:numberA,num2:numberB);
System.Console.WriteLine(numberA+ "^" +numberB+ " = " +result);