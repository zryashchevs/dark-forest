//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

// Console.Write("Введите значение M: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите значение N:");
// int n = Convert.ToInt32(Console.ReadLine());
// void che(int m, int n)
// {
// if (m > n)
// return;
// if (m % 2 == 0)
// {
// Console.Write($"{m}, ");
// }
// che(m+1,n);

// }
// che(m,n);


//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// {
//         Console.WriteLine(Akkerman(7, 12));
//         }

//         int Akkerman(int n, int m) 
//         {
//             if (n < 0 || m < 0) throw new ArgumentOutOfRangeException();
//             if (n == 0) return m + 1;
//             if (m == 0) return Akkerman(n - 1, m);
//             return Akkerman(n - 1, Akkerman(n, m - 1));
//         }



//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.


char[] charArray = "Hello world!".ToCharArray();
        {
        Console.WriteLine(GetReversArray(charArray.Length-1, charArray));
        }

        string GetReversArray(int index, char[] array)
        {
            if(index < 0) return "";
            return array[index] + GetReversArray(--index, array);
        }
