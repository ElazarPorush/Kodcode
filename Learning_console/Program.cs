// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = { 1, 5, 2, 9, 7 };
void function()
{
    Array.Sort(numbers);
    foreach (int item in numbers)
    {
        Console.WriteLine(item);
        //Console.WriteLine(numbers[4]); 
    }
}
function();
//Array.ForEach(numbers);
Console.WriteLine();

Console.WriteLine(Array.Find(numbers, item => item % 2 == 0));
//foreach (int item in numbers)
//{ 
//    if (item % 2 == 0)
//    {

//    Console.WriteLine(item);
//        break;
//    }
//}
Console.WriteLine();
Array.Reverse(numbers);
foreach (int item in numbers)
{
    Console.WriteLine(item);
    //Console.WriteLine(numbers[4]); 
}