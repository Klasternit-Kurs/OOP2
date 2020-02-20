using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
	class Program
	{
		public int ProbniBroj = 100;
		public static int ProbniBroj2 = 200;

		static void Main(string[] args)
		{
			Program.ProbniBroj2++;
			Program p = new Program();
			p.ProbniBroj++;

			int[] niz = { 5, 10 };

			Osoba Pera = new Osoba("Pera", "Peric");
			int zbir = Pera.Sabirac(niz);

			Osoba Marko = new Osoba();

			
			
			Console.WriteLine($"X:{niz[0]} Y:{niz[1]}");
			//Krace int x = 6, y = 10;

			zbir = Marko.Sabirac(niz);

			Console.WriteLine($"X:{niz[0]} Y:{niz[1]}");
			Console.ReadKey();
			
			Osoba o = new Osoba();
			o.Sabirac(niz);

			int asd = 5;
			asd.ToString();

			int.Parse("41");
			Osoba.FooBar();
		}
	}

	class Osoba
	{
		public static void FooBar()
		{
			Console.WriteLine("asd");
		}
		public static string test;
		//Stanja
		public string ime;
		public string prezime;
		public string ulica;
		public string broj;
		public string grad;
		public string postanski;
		public string JMBG;

		public int Sabirac(int[] brojevi)
		{
			brojevi[0] += 15;
			brojevi[1] *= 2;
			
			return brojevi[0] + brojevi[1];
		}

		//Konstruktor
		public Osoba(string i, string p)
		{
			ime = i;
			prezime = p;
			JMBG = "1234567890";
			grad = "Novi Pazar";
		}

		public Osoba()
		{

		}
		
	}
}
