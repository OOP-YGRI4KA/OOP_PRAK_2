
using System;
using System.Text.RegularExpressions;

Console.Write("Введіть текст: ");
string text = Console.ReadLine() ?? "";

string pattern = @"\bпоган(ий|ого|ому|им|ім|а|ої|ій|у|ою|е|і|их|ими)\b";

string result = Regex.Replace(
    text,
    pattern,
    "гарн$1",
    RegexOptions.IgnoreCase
);

Console.WriteLine("Результат: " + result);
