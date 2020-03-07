using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
	class Program
	{
		static void Main(string[] args)
		{
			string szovegresz;
			string osszszoveg = "";
			while (true)
			{
				Console.WriteLine("Kérem a következő szövegrészt:");

				szovegresz = Console.ReadLine();
				if (szovegresz == "")
				{
					break;
				}
				osszszoveg += szovegresz;
				osszszoveg += " ";
			}
			//Console.WriteLine(osszszoveg);
			char[] elvalaszto = new char[] { ' ', '\t' };
			string[] words = osszszoveg.Split(elvalaszto, StringSplitOptions.RemoveEmptyEntries);
			LexRendezes.RendezesLex(words);
			char[] oszChar = osszszoveg.ToCharArray();
			MindenSzoKulonSorba.KulonSorba(words);
			Console.WriteLine(NagyA.KezdoBetuNagyA(words));			
			osszszoveg = new string(BuborekRendezes.Bubble(oszChar));
			osszszoveg = new string(KerdojelLYHelyett.LYHelyettKerdojel(oszChar));

			string TrimString = osszszoveg.Trim();

			Console.WriteLine(TrimString);
			Console.ReadKey();
		}
	}
}
