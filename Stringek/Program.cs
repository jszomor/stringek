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
			while(true)
			{
				Console.WriteLine("Kérem a következő szövegrészt:");

				szovegresz = Console.ReadLine();
				if(szovegresz == "")
				{
					break;
				}
				osszszoveg += szovegresz;
				osszszoveg += " ";
			}
			Console.WriteLine(osszszoveg);

			string[] words = osszszoveg.Split(' ');

			foreach (var word in words)
			{
				Console.WriteLine(word);
			}
			Console.ReadKey();
		}
	}
}
