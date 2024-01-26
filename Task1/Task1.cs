//Задача 1: Задайте значения M и N. Напишите программу,
//  которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.


Console.WriteLine("Enter the Number M");
string inputM = Console.ReadLine();
inputM ??= "No Data";
int M =IsIntAskingCycleAndConvert(inputM);

Console.WriteLine("Enter the number N");
string inputN = Console.ReadLine();
inputN ??= "No Data";
int N = IsIntAskingCycleAndConvert(inputN);

int IsIntAskingCycleAndConvert(string input) 
{
    int result = 0;
    while (int.TryParse(input, out result) == false)
    {
        Console.WriteLine("Enter the digit please");
        input = Console.ReadLine();
    }
    result = Convert.ToInt32(input);
    return result;
}
int myFrom = M;
int myTo = N;
if (N < M) 
{
myFrom = N;
myTo = M;
}

void PrintDigitsInArea(int from , int To) 
{
    
    if (from==To)
    {
        Console.Write(To + " ");
        return;
    }
    else 
    {
        Console.Write(from + " ");
    }
    PrintDigitsInArea(from + 1, To);
}

PrintDigitsInArea(myFrom , myTo);
Console.ReadLine();

