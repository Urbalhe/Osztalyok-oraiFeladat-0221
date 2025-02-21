namespace Osztalyok
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			Cicaaa cica = new Cicaaa("Macs", 5, 8, "Házi macska", "Foltos", 25, 35, "kandúr");
			Cicaaa cica2 = new Cicaaa("Thanos", 10, 15, "Dagadt macska", "zöld", 50, 50, "kandúr");
			Cicaaa cica3 = new Cicaaa("Tita", 3, 8, "Házi macska", "Fekete", 30, 15,  "kandúr");
			Cicaaa cica4 = new Cicaaa("Rozi", 9, 8, "Házi macska", "Bézs", 25, 30, "nőstény");

            cica.Jatek();
            Console.WriteLine();

            cica2.Jatek();
            Console.WriteLine();

            cica3.Jatek();
            Console.WriteLine();

            cica4.Jatek();

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine();
			cica.Eves(5);

            Console.WriteLine();
			cica2.Eves(10);

            Console.WriteLine();
			cica3.Eves(3);

            Console.WriteLine();
			cica4.Eves(50);

            Console.WriteLine("-----------------------------------------------------");

			cica2.Alvas();
            Console.WriteLine();
            Console.WriteLine(cica2);




        }
	}
}
