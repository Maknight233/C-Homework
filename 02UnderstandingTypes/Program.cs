// See https://aka.ms/new-console-template for more information
//1. 

using System.Numerics;

Console.WriteLine(5.0/0);
Console.WriteLine($"sbyte   {sizeof(sbyte),5} {sbyte.MinValue,25} {sbyte.MaxValue,25}");
Console.WriteLine($"byte    {sizeof(byte),5} {byte.MinValue,25} {byte.MaxValue,25}");
Console.WriteLine($"short   {sizeof(short),5} {short.MinValue,25} {short.MaxValue,25}");
Console.WriteLine($"ushort  {sizeof(ushort),5} {ushort.MinValue,25} {ushort.MaxValue,25}");
Console.WriteLine($"int     {sizeof(int),5} {int.MinValue,25} {int.MaxValue,25}");
Console.WriteLine($"uint    {sizeof(uint),5} {uint.MinValue,25} {uint.MaxValue,25}");
Console.WriteLine($"long    {sizeof(long),5} {long.MinValue,25} {long.MaxValue,25}");
Console.WriteLine($"ulong   {sizeof(ulong),5} {ulong.MinValue,25} {ulong.MaxValue,25}");
Console.WriteLine($"float   {sizeof(float),5} {float.MinValue,25} {float.MaxValue,25}");
Console.WriteLine($"double  {sizeof(double),5} {double.MinValue,25} {double.MaxValue,25}");
Console.WriteLine($"decimal {sizeof(decimal),5} {decimal.MinValue,25} {decimal.MaxValue,25}");
//2.
int input = 1;
int years = input * 100;
int days = years * 365;
long hours = days * 24L;
long minutes = hours * 60L;
long seconds = minutes * 60L;
long milliseconds = seconds * 1000L;

BigInteger microseconds = (BigInteger)milliseconds * 1000;
BigInteger nanoseconds = microseconds * 1000;

Console.WriteLine( $"{input} centuries = {years} years = {days} days = {hours} hours = " + 
                   $"{minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = " +
                   $"{microseconds} microseconds = {nanoseconds} nanoseconds");
input = 5;
Console.WriteLine( $"{input} centuries = {years} years = {days} days = {hours} hours = " + 
                   $"{minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = " + 
                   $"{microseconds} microseconds = {nanoseconds} nanoseconds");    