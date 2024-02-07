/*
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
в промежутке от M до N. Использовать рекурсию, не использовать циклы.
*/
/*
Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N:");
int n = Convert.ToInt32(Console.ReadLine());
void che(int m, int n)
{
if (m > n)
return;
if (m % 2 == 0)
{
Console.Write($"{m}, ");
}
che(m+1,n);

}
che(m,n);
*/

/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

/*
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(m,n);

// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}
*/

/*
Задайте произвольный массив. Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/

char[] charArray = "Hello world!".ToCharArray();
    {
    Console.WriteLine(GetReversArray(charArray.Length-1, charArray));
    }

    string GetReversArray(int index, char[] array)
    {
        if(index < 0) return "";
        return array[index] + GetReversArray(--index, array);
    }