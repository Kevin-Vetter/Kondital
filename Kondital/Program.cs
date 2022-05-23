using KonditalClass;

int maxPuls;
int hvilePuls;

while (true)
{
    if (int.TryParse(Console.ReadLine(), out maxPuls))
    {
        break;
    }
}

while (true)
{
    if (int.TryParse(Console.ReadLine(), out hvilePuls))
    {
        break;
    }
}
Console.WriteLine(Kondital.BeregnKondital(hvilePuls, maxPuls));

