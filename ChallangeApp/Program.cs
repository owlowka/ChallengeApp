string name = "Ewa";
bool woman = true;
int age = 28;

var message = (woman, age) switch
{
    (true, < 30) => "Kobieta poniżej 30 lat",
    (true, _) => ($"{name}, lat {age}"),
    (false, < 18) => "Niepełnoletni mężczyzna",
};

Console.WriteLine(message);
