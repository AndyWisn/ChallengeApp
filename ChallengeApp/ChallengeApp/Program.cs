var name = "Ewa";
var sex = 'K';      // Płeć: K/k - kobieta,  M/m mężczyzna,  I/i - inna
byte age = 29;

// Zakładam, że Ewa to zawsze kobieta, inaczej warunki się nieco skomplikują

if (sex == 'K' || sex == 'k')
{
    if (age < 30) Console.WriteLine("Kobieta poniżej 30 lat");
    else if (age == 30 && name == "Ewa") Console.WriteLine("Ewa, lat 30");
}
else if ((sex == 'M' ||sex == 'm') && age < 18) Console.WriteLine("Niepłnoletni mężczyzna");

