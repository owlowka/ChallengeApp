
int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();
int[] digits = new int[10];

foreach (char letter in letters)
{
    int digit = int.Parse(letter.ToString());
    digits[digit]++;
}

for (int i = 0;i < digits.Length; i++)
{
    Console.WriteLine($"{i} => {digits[i]}");
}

