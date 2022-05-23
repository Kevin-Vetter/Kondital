namespace KonditalClass
{
    public class Kondital
    {
        static public int TryParse()
        {
            int _value;
            while (!int.TryParse(Console.ReadLine(), out _value))
            {
                Console.Clear();
                Console.WriteLine("Ugyldig værdi!");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Indtast et tal: ");
            }
            return _value;
        }

        static public double BeregnKondital(int hvilePuls, int maxPuls)
        {
            return Math.Round(maxPuls / hvilePuls * 15.3);
        }

        static public double BeregnIltoptagelseFeature(int hvilePuls, int maxPuls, int vaegt)
        {
            return Math.Round(BeregnKondital(hvilePuls, maxPuls) * vaegt / 1000, 1);
        }

        static public void Wait()
        {
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}