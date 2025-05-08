// See https://aka.ms/new-console-template for more information

// 1. Cannot find the WriteLine function; need add Console
// int max = 500;
// for (byte i = 0; i < max; i++)
// {
//     Console.WriteLine(i);
// }

//3. 
// int correctNumber = new Random().Next(3) + 1;
// while (true)
// {
//     int guessedNumber = int.Parse(Console.ReadLine());
//     if (guessedNumber < 1 || guessedNumber > 3)
//     {
//         Console.WriteLine("Invalid number, number should be between 1 and 3");
//     }
//     else
//     {
//         if (guessedNumber > correctNumber)
//         {
//             Console.WriteLine("Higher than correct number");
//         }else if (guessedNumber < correctNumber)
//         {
//             Console.WriteLine("Lower than correct number");
//         } else if (guessedNumber == correctNumber)
//         {
//             Console.WriteLine("Correct");
//             break;
//         }
//     }
// }

//2.

// using System.Runtime.InteropServices;
//
// int total = 5;
// string ans = "";
// for (int i = 1; i <= 9; i+=2)
// {
//     for (int j = 0; j < (total - i); j++)
//     {
//         ans += " ";
//     }
//
//     for (int k = 0; k < i; k++)
//     {
//         ans += "*";
//     }
//
//     ans += "\n";
//
//     total++;
// }
// Console.WriteLine(ans);

//4.

using System.Runtime.InteropServices.JavaScript;
//
// DateTime birthDate =  new DateTime(1982, 02, 28);
// Console.WriteLine(birthDate);
// DateTime end = DateTime.Now;
// TimeSpan time = end - birthDate;
//
// int daysToNextAnniversary = 10000 - (time.Days % 10000);
//
// Console.WriteLine(time.Days);
// Console.WriteLine(daysToNextAnniversary);

//5.
TimeOnly now = TimeOnly.FromDateTime(DateTime.Now);
TimeOnly morning = new TimeOnly(6, 0, 0, 0, 0);
TimeOnly noon = new TimeOnly(12, 0, 0, 0, 0);
TimeOnly evening = new TimeOnly(18, 0, 0, 0, 0);
TimeOnly night = new TimeOnly(20, 0, 0, 0, 0);
if (now.CompareTo(noon) <= 0 && now.CompareTo(morning) >= 0)
{
    Console.WriteLine("Good Morning");
} else if (now.CompareTo(evening) <= 0 && now.CompareTo(noon) > 0)
{
    Console.WriteLine("Good Afternoon");
}else if (now.CompareTo(evening) > 0 && now.CompareTo(night) <= 0)
{
    Console.WriteLine("Good Evening");
}
else
{
    Console.WriteLine("Good Night");
}

//6.
for (int i = 1; i <= 4; i++)
{
    for (int j = 0; j < 24; j += i)
    {
        Console.Write(j + ", ");
    }
    Console.WriteLine(24);
}