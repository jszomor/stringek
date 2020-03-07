using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringek
{
	class MindenSzoKulonSorba
	{
		public static void KulonSorba(string[] words)
		{
			int szamlalo = 0;
			bool megvan;
			string[] egyedi = new string[words.Length];
			for (int i = 0; i < words.Length; i++)
			{
				megvan = false;
				for (int j = 0; j < szamlalo; j++)
				{
					if (words[i] == egyedi[j])
					{
						megvan = true;
						break;
					}
				}
				if (megvan == false)
				{
					egyedi[szamlalo] = words[i];
					szamlalo++;
				}
			}
			for (int i = 0; i < szamlalo; i++)
			{
				Console.WriteLine(egyedi[i]);
			}
		}
	}
}
