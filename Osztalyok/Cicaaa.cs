using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osztalyok
{
	internal class Cicaaa
	{
		private string nev;
		private int kor;
		private int suly;
		private string szin;
		private string fajta;
		private int rendetlensegiSzint;
		private int fogyasztas;
		private bool ehes;
		private string nem;



		public Cicaaa(string nev, int kor, int suly, string fajta, int rendetlensegiSzint, int fogyasztas, string nem)
		{
			this.nev = nev;
			this.kor = kor;
			this.suly = suly;
			this.fajta = fajta;
			this.rendetlensegiSzint = rendetlensegiSzint;
			this.fogyasztas = fogyasztas;
			this.nem = nem;
			ehes = true;
		}

		public void Eves(double kajaSuly)
		{
			Random random = new Random();
			int esely = random.Next(101);

			ehes = false;

			if (esely <= 4)
			{
				Console.WriteLine($"{nev} ételmérgezett lett :( ");

				szin = "zöld";
				suly -= (int)(suly * (esely / 100.0));
				rendetlensegiSzint /= 2;

			}

			else
			{
				Console.WriteLine($"{nev} megette a kaját és jól esett neki.");
				suly += (int)Math.Ceiling(fogyasztas * kajaSuly);
			}

		}

		public void Alvas()
		{
			rendetlensegiSzint = 0;

			if (szin == "zöld")
			{
				szin = "Eredeti";
			}
		}


		public void Ebredes()
		{
			rendetlensegiSzint = 100;
			ehes = true;
		}

		public void RomlottKaja()
		{
			Console.WriteLine($"{nev} evett egy romlott kaját.");
			Eves(0.5);
		}

		public void Aktivitas()
		{
			if (0 <= kor && kor <= 8)
			{
				rendetlensegiSzint = rendetlensegiSzint * 1;
			}

			else if (8 < kor && kor < 20)
			{
				rendetlensegiSzint = rendetlensegiSzint / 2;
			}
		}

		public void Fajbesorolas()
		{
			if (szin == "narancs")
			{
				rendetlensegiSzint = rendetlensegiSzint * 2;
			}

			else if (szin == "fekete")
			{
				rendetlensegiSzint = rendetlensegiSzint / 2;
			}




		}

		public void Jatek()
		{
			List <string> lehetosegek = new List<string> { "Ugrál", "Tomból", "Ered", "Rohan", "Nyávog", "Kapar", "Támad", "Játszik", "Gombolyagot üldöz", "Eszik" };

			Random random = new Random();
			string cselekves = "";

			if(rendetlensegiSzint <= 0 && rendetlensegiSzint <=25)
			{
				cselekves = lehetosegek[random.Next(0, 2)];
				Console.WriteLine($"{nev} éppen {cselekves}.");
			}

			else if(rendetlensegiSzint <= 25 && rendetlensegiSzint <= 50)
			{
				cselekves = lehetosegek[random.Next(0, 4)];
				Console.WriteLine($"{nev} éppen {cselekves}.");
			}

			else if (rendetlensegiSzint <= 50 && rendetlensegiSzint <= 75)
			{
				cselekves = lehetosegek[random.Next(0, 7)];
				Console.WriteLine($"{nev} éppen {cselekves}.");
			}

			else if (rendetlensegiSzint <= 75)
			{
				cselekves = lehetosegek[random.Next(0, 9)];
				Console.WriteLine($"{nev} éppen {cselekves}-.");
			}
		}

	}



}
