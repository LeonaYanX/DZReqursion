//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//Даны два неотрицательных числа m и n

Random random = new Random();
int MYm = random.Next(0, 4);       
Console.WriteLine($"m = {MYm}");
int MYn = random.Next(0,11);
Console.WriteLine($"n = {MYn}");
int Akerman(int m , int n) 
{
    int result = 0;
    if (m==0)
    {
        result = n+1;
        return result;
    }
    if (n == 0)
    {
        result = Akerman(m - 1, 1);
        return result;
    }
    else 
    {
        result = Akerman(m - 1, Akerman(m, n - 1));
        return result;
    }

}
Console.Write("Result is = ");
Console.WriteLine(Akerman(MYm, MYn));


// для красоты 

//int mAgain = 3;
//int nAgain = 2;
//for (int i = 0; i <= mAgain; i++) 
//{
//   for (int j = 0; j <= nAgain; j++) 
//    {
//        Console.WriteLine($"For m = {i} and n = {j}");
//        Console.WriteLine("Akermann function is equal to - ");
//        Console.WriteLine(Akerman(i , j));
//    }
//}
Console.ReadLine();