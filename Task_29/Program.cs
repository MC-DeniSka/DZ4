// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

double [] CreatingAnArray()
{
    int len = 0;
    System.Console.WriteLine("Введите длину массива (целое число)");
    len = Convert.ToInt32(Console.ReadLine());
    if(len > 0)
    {
        double [] massive = new double [len]; 
        for (int i = 0; i < len; i++)
        {
            System.Console.WriteLine("Введите элемент массива");
            massive [i]  = double.Parse(Console.ReadLine()!);
        }
        return massive;
    }
    else
    {
        System.Console.WriteLine("Ошибка! Вы ввели отрицательное число ");
        double [] errors = new double [0];
        return errors;
    }
}


void PrintArray(double [] array)
{
    System.Console.Write("{");
    System.Console.Write(String.Join(", ",array));
    System.Console.Write("}");
}

double [] massive = CreatingAnArray();
PrintArray(massive);
