// //task1
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Even : " + EvenCount(n));
// Console.WriteLine("Odd : " + OddCount(n));
// Console.WriteLine("Zeros : " + ZeroCount(n));
// Console.WriteLine("Digits : " + DigitCount(n));
// Console.WriteLine("Min : " + MinDigit(n));
// Console.WriteLine("Max : " + MaxDigit(n));
// Console.WriteLine("Sum of Digits: " + SumDigit(n));

// int EvenCount(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         int digit = n % 10;
//         if (digit % 2 == 0 && digit != 0)
//         {
//             count++;
//         }
//         n = n / 10;
//     }
//     return count;
// }

// int OddCount(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         int digit = n % 10;
//         if (digit % 2 != 0)
//         {
//             count++;
//         }
//         n = n / 10;
//     }
//     return count;
// }

// int ZeroCount(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         if (n % 10 == 0)
//         {
//             count++;
//         }
//         n = n / 10;
//     }
//     return count;
// }

// int DigitCount(int n)
// {
//     int count = 0;
//     while (n > 0)
//     {
//         count++;
//         n = n / 10;
//     }
//     return count;
// }

// int MinDigit(int n)
// {
//     int min = 9;
//     while (n > 0)
//     {
//         int digit = n % 10;
//         if (digit < min)
//         {
//             min = digit;
//         }
//         n = n / 10;
//     }
//     return min;
// }

// int MaxDigit(int n)
// {
//     int max = 0;
//     while (n > 0)
//     {
//         int digit = n % 10;
//         if (digit > max)
//         {
//             max = digit;
//         }
//         n = n / 10;
//     }
//     return max;
// }

// int SumDigit(int n)
// {
//     int sum = 0;
//     while (n > 0)
//     {
//         sum = sum + n % 10;
//         n = n / 10;
//     }
//     return sum;
// }


//task2
// int grade = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CheckGrade(grade));

// char CheckGrade(int grade)
// {
//     if (grade >= 90)
//     {
//         return 'A';
//     }
//     else if (grade >= 80)
//     {
//         return 'B';
//     }
//     else if (grade >= 70)
//     {
//         return 'C';
//     }
//     else if (grade >= 60)
//     {
//         return 'D';
//     }
//     else
//     {
//         return 'F';
//     }
// }


//task3
// int N = Convert.ToInt32(Console.ReadLine());

// int negative = 0;
// int positive = 0;
// int zeros = 0;
// int even = 0;
// int odd = 0;
// int sum = 0;
// int max = 0;
// int min = 0;

// for (int i = 0; i < N; i++)
// {
//     int x = Convert.ToInt32(Console.ReadLine());

//     if (i == 0)
//     {
//         max = x;
//         min = x;
//     }

//     if (x < 0)
//     {
//         negative++;
//     }
//     else if (x > 0)
//     {
//         positive++;
//     }
//     else
//     {
//         zeros++;
//     }

//     if (x % 2 == 0)
//     {
//         even++;
//     }
//     else
//     {
//         odd++;
//     }

//     if (x > max)
//     {
//         max = x;
//     }
//     if (x < min)
//     {
//         min = x;
//     }

//     sum = sum + x;
// }

// Console.WriteLine("Negative = " + negative);
// Console.WriteLine("Positive = " + positive);
// Console.WriteLine("Zeros = " + zeros);
// Console.WriteLine("Even = " + even);
// Console.WriteLine("Odd = " + odd);
// Console.WriteLine("Max = " + max);
// Console.WriteLine("Min = " + min);
// Console.WriteLine("Sum of Digits = " + sum);

//task4
// int n = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[n];
// for (int i = 0; i < n; i++)
// {
//     a[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < n; i += 2)
// {
//     Console.Write(a[i] + " ");
// }


//task5
// int n = Convert.ToInt32(Console.ReadLine());
// int[] a = new int[n];
// for (int i = 0; i < n; i++)
// {
//     a[i] = Convert.ToInt32(Console.ReadLine());
// }
// int count = 0;
// for (int i = 1; i < n; i++)
// {
//     if (a[i] > a[i - 1])
//     {
//         count++;
//     }
// }
// Console.WriteLine(count);


//task6
// int n = Convert.ToInt32(Console.ReadLine());

// int[] a = new int[n];
// for (int i = 0; i < n; i++)
// {
//     a[i] = Convert.ToInt32(Console.ReadLine());
// }

// for (int i = 0; i < n; i++)
// {
//     int count = 0;
//     for (int j = 0; j < n; j++)
//     {
//         if (a[i] == a[j])
//         {
//             count++;
//         }
//     }

//     if (count > 1)
//     {
//         Console.Write(a[i] + " ");
//     }
// }



//task7
// Console.Write("From = ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("To = ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("-------------------------------");
// for (int i = x; i <= y; i++)
// {
//     for (int j = 1; j <= 10; j++)
//     {
//         Console.WriteLine(i + "x" + j + "= " + i * j);
//     }
//     Console.WriteLine("-------------------------------");
// }


//task9
// Console.Write("Input the base value : ");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input the exponent : ");
// int exp = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("The value of " + b + " to the power of " + exp + " is : " + Power(b, exp));

// long Power(int b, int exp)
// {
//     if (exp == 0)
//     {
//         return 1;
//     }
//     return b * Power(b, exp - 1);
// }


//task10
Console.Write("Input number of terms for the Fibonacci series : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("The Fibonacci series of " + n + " terms is : ");
for (int i = 0; i < n; i++)
{
    Console.Write(Fib(i) + " ");
}

int Fib(int k)
{
    if (k == 0)
    {
        return 0;
    }
    if (k == 1)
    {
        return 1;
    }
    return Fib(k - 1) + Fib(k - 2);
}