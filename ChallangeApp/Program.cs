
using System.Diagnostics.Metrics;

int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

List<char> digits = new List<char>();
digits.Add('0');
digits.Add('1');
digits.Add('2');
digits.Add('3');
digits.Add('4');
digits.Add('5');
digits.Add('6');
digits.Add('7');
digits.Add('8');
digits.Add('9');


foreach (var digit in digits)
{
    int digitCount = letters.Count(letter => letter == digit);
        Console.WriteLine($"{digit} => {digitCount}");
}

