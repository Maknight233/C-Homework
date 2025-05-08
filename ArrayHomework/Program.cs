// See https://aka.ms/new-console-template for more information

//1. 
// int[] arr = new int[10];
// for (int i = 0; i < 10; i++)
// {
//     arr[i] = i + 1;
// }
//
// int[] arr2 = new int[10];
// for (int i = 0; i < 10; i++)
// {
//     arr2[i] = arr[i];
// }
//
// Array.ForEach(arr, x => Console.Write(x + ","));
// Console.WriteLine();
// Array.ForEach(arr2, x => Console.Write(x + ","));


//2.
// List<string> list = new List<string>();
//
// while (true)
// {
//     Console.WriteLine("Enter command (+ item, - item, or -- to clear)):");
//     string command = Console.ReadLine();
//     if (command.StartsWith("+"))
//     {
//         list.Add(command.Substring(2));
//     } else if (command.StartsWith("- "))
//     {
//         if (list.Contains(command.Substring(2)))
//         {
//             list.Remove(command.Substring(2));
//         }
//         else
//         {
//             Console.WriteLine("list doesn't contain element" + command.Substring(2));
//         }
//     } else if (command.CompareTo("--") == 0)
//     {
//         list.Clear();
//         break;
//     }
//     else
//     {
//         Console.WriteLine("Invalid command");
//     }
// }

//3.
// using ArrayHomework;
// Array.ForEach(SumOfPrime.prime(2,10), i => Console.Write(i + ", "));
// Console.WriteLine();

string s = Console.ReadLine(); 
char[] cs = s.Reverse().ToArray();
Array.ForEach(cs, c => Console.Write(c));
Console.WriteLine();
string[] ns = s.Split( new char[] { ' ' , ',', '.', ':', ';', '=', '(', ')', '&', '[', ']', '"', '\'', '\\', '/', '!', '?'});

Array.ForEach(ns, n => Console.Write(n + " "));