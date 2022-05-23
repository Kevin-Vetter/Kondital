using KonditalClass;

Console.WriteLine("Indtast maximal puls: ");
int maxPuls = Kondital.TryParse();
Kondital.Wait();
Console.WriteLine("Indtast hvile puls: ");
int hvilePuls = Kondital.TryParse();
Kondital.Wait();
Console.WriteLine("Indtast vægt: ");
int vaegt = Kondital.TryParse();
Kondital.Wait();

Console.WriteLine("Kondital: " + Kondital.BeregnKondital(hvilePuls, maxPuls) + " ml/kg/min");
Console.WriteLine("Maximal Iltoptagelse: " + Kondital.BeregnIltoptagelseFeature(hvilePuls, maxPuls, vaegt) + " l/ml");