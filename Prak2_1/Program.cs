
using System;
using System.Text.RegularExpressions;

Console.Write("Введіть логін: ");
string login = Console.ReadLine() ?? "";

string pattern = @"\A\p{L}[\p{L}\d]{1,9}\z";

if (Regex.IsMatch(login, pattern))
{
    Console.WriteLine("Логін коректний!");
}
else
{
    Console.WriteLine("Логін некоректний!");
}
