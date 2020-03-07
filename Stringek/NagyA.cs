using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
	class NagyA
	{
		public static string KezdoBetuNagyA(string[] words)
		{
			string nagyKezdoA;
			string osszesA = "";
			for (int i = 0; i < words.Length; i++)
			{
				if (words[i].StartsWith("a"))
				{
					char[] word = words[i].ToCharArray();

					word[0] = char.ToUpper(word[0]);

					nagyKezdoA = new string(word);
					osszesA += nagyKezdoA;
					osszesA += " ";
				}
			}
			return osszesA;
		}
	}
}
