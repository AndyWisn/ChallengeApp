
int number = 1223330076;

byte[] counters = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

for (var i = 0; i < letters.Length; i++)
{
    counters[(byte)Char.GetNumericValue(letters[i])]++;

}

for (var i = 0; i < 10; i++)
{
    Console.WriteLine(i + " => " + counters[i]);
}

