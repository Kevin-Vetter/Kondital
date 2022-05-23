using KonditalClass;

int maxPuls;
int hvilePuls;

while (true)
{
    if (int.TryParse(Console.ReadLine(), out maxPuls))
    {
       // Console.WriteLine(maxPuls);
        break;
    }
}

while (true)
{
    if (int.TryParse(Console.ReadLine(), out hvilePuls))
    {
       // Console.WriteLine(hvilePuls);
        break;
    }
}
Console.WriteLine(Kondital.BeregnKondital(hvilePuls, maxPuls));

