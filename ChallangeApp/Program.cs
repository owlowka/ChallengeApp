string name = "Ewa";
bool woman = true;
int age = 28;

if ( woman == true)
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine($"{name}, lat {age}");
    }
}
else if ( woman == false && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}